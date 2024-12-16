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
            short employeeNum = 32000;
            int chinaPopulation = 700000000;
            float marathonDistance = 42195.1345594f;
            double apartmentWidth = 1320.1134534523452345d;
            decimal virusCount = 6567000000000000000;

            textBox_print.Text += classCount.GetType()+" : ";
            textBox_print.Text += classCount.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += employeeNum.GetType() + " : ";
            textBox_print.Text += employeeNum.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += chinaPopulation.GetType() + " : ";
            textBox_print.Text += chinaPopulation.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += marathonDistance.GetType() + " : ";
            textBox_print.Text += marathonDistance.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += apartmentWidth.GetType() + " : ";
            textBox_print.Text += apartmentWidth.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += virusCount.GetType() + " : ";
            textBox_print.Text += virusCount.ToString();



        }
    }
}
