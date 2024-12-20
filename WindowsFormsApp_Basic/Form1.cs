using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Basic
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            textBox_print.Text = "";


            int studentNum = Int32.Parse(textBox_input.Text);
            int[] studentNumArray = new int[studentNum];

            string[] studentNameArray = new string[studentNum];

            for(int a = 0; a<studentNum; a++)
            {
                studentNameArray[a] = "학생" + (a+1);
                studentNumArray[a] = random.Next(0,100);

                printMsg(studentNameArray[a], studentNumArray[a]);
            }
        }

        void printMsg(string studentName, int studentScore)
        {
            textBox_print.Text += studentName + "의 점수: " + studentScore + "\r\n";
        }
    }
}
