using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Basic
{
    public partial class ThreadPractice : Form
    {
        BackgroundWorker worker;
        public ThreadPractice()
        {
            InitializeComponent();

            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            this.worker = new BackgroundWorker();
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;

            this.worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            this.worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_Complete);
        }

        void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(30);
                this.worker.ReportProgress(i);
            }
        }

        void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        void Worker_Complete(object sender, EventArgs e)
        {
            MessageBox.Show("complete");
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (!this.worker.IsBusy)
            {
                this.worker.RunWorkerAsync();
            }
        }
    }
}
