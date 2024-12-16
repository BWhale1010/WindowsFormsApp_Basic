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
            short employeeNum_SeoulBranch = 32000;
            int chinaPopulation = 700000000;
            float marathonDistance_m = 42195.1345594f;
            double apartmentWidth_km2 = 1320.1134534523452345d;
            decimal virusCount_experiment = 6567000000000000000;

            textBox_print.Text += classCount.GetType()+" : ";
            textBox_print.Text += classCount.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += employeeNum_SeoulBranch.GetType() + " : ";
            textBox_print.Text += employeeNum_SeoulBranch.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += chinaPopulation.GetType() + " : ";
            textBox_print.Text += chinaPopulation.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += marathonDistance_m.GetType() + " : ";
            textBox_print.Text += marathonDistance_m.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += apartmentWidth_km2.GetType() + " : ";
            textBox_print.Text += apartmentWidth_km2.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += virusCount_experiment.GetType() + " : ";
            textBox_print.Text += virusCount_experiment.ToString();



        }
    }
}
