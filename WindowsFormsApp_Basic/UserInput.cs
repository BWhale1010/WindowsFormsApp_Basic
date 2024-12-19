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
    public partial class UserInput : Form
    {
        private bool randomResult;
        private string userInput;

        public UserInput()

        {
            InitializeComponent();
        }

        private void radioButton_true_Click(object sender, EventArgs e)
        {
            if (radioButton_true.Checked)
            {
                userInput = "true";
                textBox_input.Text = userInput;

                randomResult = coinThrowAndResult();
                printResult(userInput, randomResult);
            }
        }

        private void radioButton_false_Click(object sender, EventArgs e)
        {
            if (radioButton_false.Checked)
            {
                userInput = "false";
                textBox_input.Text = userInput;

                randomResult = coinThrowAndResult();
                printResult(userInput, randomResult);
            }
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            userInput = textBox_input.Text.ToLower();

            if (userInput.Equals("true") || userInput.Equals("false"))
            {
                if (userInput.Equals("true"))
                {
                    radioButton_true.Checked = true;
                }
                else if (userInput.Equals("false"))
                {
                    radioButton_false.Checked = true;
                }

                randomResult = coinThrowAndResult();
                printResult(userInput, randomResult);
            }
            else
            {
                textBox_print.Text = "true, false 값만 입력해 주세요.";
            }
        }

        private bool coinThrowAndResult()
        {
            Random random = new Random();
            int randomNum = random.Next(0, 100);
            int resultNum = randomNum % 2;

            bool result = false;

            if (resultNum == 0)
            {
                result = false;
            } 
            else if (resultNum == 1)
            {
                result = true;
            }

            return result;
        }

        private void printResult(string userInput, bool randomResult)
        {
            textBox_print.Text = "입력하신 값은 " + userInput + "입니다.\r\n";
            textBox_print.Text += "동전 던지기 결과...\r\n";

            if (userInput.Equals("true") && randomResult)
            {
                textBox_print.Text += "승리~!";
            }
            else if (userInput.Equals("false") && !randomResult)
            {
                textBox_print.Text += "승리~!";
            }
            else
            {
                textBox_print.Text += "패배..";
            }
        }
    }
}
