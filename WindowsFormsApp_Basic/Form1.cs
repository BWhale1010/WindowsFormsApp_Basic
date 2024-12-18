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

            int a = 10;
            int b = 3;

            int[] returnNumArray = divide(a, b);

            textBox_print.Text = "나누기 : "+returnNumArray[0].ToString() + ", 나머지 : "  + returnNumArray[1];

        }

        int[] divide(int a, int b)
        {
            int[] numArray = new int[2];
            numArray[0] = a / b;
            numArray[1] = a%b;

            return numArray;
        }
    }
}
