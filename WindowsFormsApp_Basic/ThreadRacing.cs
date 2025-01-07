using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_Basic
{
    public partial class ThreadRacing : Form
    {
        Thread[] racingThreads;
        Stopwatch stopwatch;
        private Random random = new Random();
        static Object lockObject = new Object();
        bool[] carStop;
        int[] carDriving;

        public ThreadRacing()
        {
            InitializeComponent();

            racingThreads = new Thread[5];

            stopwatch = new Stopwatch();
        }

        void RandomSleep()
        {
            int sleepTime = (int)(random.NextDouble() * 900.0)+100;
            Thread.Sleep(sleepTime);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ProgressBar[] progressBars =
{
                progressBar1, progressBar2, progressBar3, progressBar4, progressBar5
            };

            foreach (var progressBar in progressBars)
            {
                progressBar.Style = ProgressBarStyle.Continuous;
                progressBar.Minimum = 0;
                progressBar.Maximum = 10;
                progressBar.Step = 1;
                progressBar.Value = 0;
            }

            carStop = new bool[5];
            carDriving = new int[5];

            textBox1.Text = "레이싱 시작~!\r\n\r\n";
            stopwatch.Restart();

            lock (lockObject)
            {
                for (int i = 0; i < 5; i++)
                {
                    int carNum = i;
                    racingThreads[carNum] = new Thread(() => driveThreadStart(carNum));
                    racingThreads[carNum].Start();
                    textBox1.Text += i + 1 + "번 차 출발\r\n";
                }
                textBox1.Text += "\r\n";
            }
        }

        void driveThreadStart(int carNum)
        {
            long startTime = stopwatch.ElapsedMilliseconds;

            while (!carStop[carNum])
            {
                carDriving[carNum]++;
                
                ProgressPrint(carNum);

                if (carDriving[carNum] == 10)
                {
                    carStop[carNum] = true;
                    long arriveTime = stopwatch.ElapsedMilliseconds - startTime;

                    if (textBox1.InvokeRequired)
                    {
                        textBox1.Invoke(new Action(() =>
                            textBox1.Text += $"{carNum + 1}번 차 도착 : {arriveTime}ms\r\n\r\n"
                        ));
                    }
                    else
                    {
                        textBox1.Text += $"{carNum + 1}번 차 도착 : {arriveTime}ms\r\n\r\n";
                    }
                }
                
                RandomSleep();
            }
        }

        void ProgressPrint(int carNum)
        {
            System.Windows.Forms.ProgressBar[] progressBars = { progressBar1, progressBar2, progressBar3, progressBar4, progressBar5 };

            if (progressBars[carNum].InvokeRequired)
            {
                progressBars[carNum].Invoke(new MethodInvoker(() =>
                {
                    progressBars[carNum].Value += progressBars[carNum].Step;
                }
                ));
            }
            else
            {
                progressBars[carNum].Value += progressBars[carNum].Step;
            }
        }
    }
}
