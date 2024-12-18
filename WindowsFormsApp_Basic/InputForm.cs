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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            textBox_result.Text = textBox_input.Text;
            textBox_input.Text = "";
        }

        private void textBox_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                textBox_result.Text = textBox_input.Text;
                textBox_input.Text = "";
            }
        }
    }
}
