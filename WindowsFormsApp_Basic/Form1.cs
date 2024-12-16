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

            byte classCount = 10;
            short employeeNum = 100;
            int boardNum = 405004004;
            float marathonDistance = 42.195f;
            double apartmentWidth = 10.11d;
            decimal worldPopulation = 7000000000;

            textBox_print.Text += classCount.GetType()+" : ";
            textBox_print.Text += classCount.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += employeeNum.GetType() + " : ";
            textBox_print.Text += employeeNum.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += boardNum.GetType() + " : ";
            textBox_print.Text += boardNum.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += marathonDistance.GetType() + " : ";
            textBox_print.Text += marathonDistance.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += apartmentWidth.GetType() + " : ";
            textBox_print.Text += apartmentWidth.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += worldPopulation.GetType() + " : ";
            textBox_print.Text += worldPopulation.ToString();



        }
    }
}
