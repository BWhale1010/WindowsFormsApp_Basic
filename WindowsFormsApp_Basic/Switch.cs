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
    public partial class Switch : Form
    {
        enum Week{
            sunday = 0,
            monday = 1,
            tuesday = 2,
            wednesday = 3,
            thursday = 4,
            friday = 5,
            saturday = 6
        }

        int userInputCovertNum;
        

        public Switch()
        {
            InitializeComponent();

            textBox_print.Text = "요일을 영어로 적어주세요.";
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            Week userInput = convertUserInput(textBox_input.Text);


            switch (userInput)
            {
                case 0:
                    textBox_print.Text = "일요일 좋아";
                    break;
                case (Week)1:
                    textBox_print.Text = "월요일 싫어";
                    break;
                case (Week)2:
                    textBox_print.Text = "화요일 싫어";
                    break;
                case (Week)3:
                    textBox_print.Text = "수요일 싫어";
                    break;
                case (Week)4:
                    textBox_print.Text = "목요일 싫어";
                    break;
                case (Week)5:
                    textBox_print.Text = "금요일 싫어";
                    break;
                case (Week)6:
                    textBox_print.Text = "토요일 좋아";
                    break;
                case (Week)7:
                    textBox_print.Text = "올바른 요일을 작성해 주세요.";
                    break;
            }
        }

        Week convertUserInput(string userInput)
        {
            userInput = userInput.ToLower();

            switch (userInput)
            {
                case "sunday":
                    userInputCovertNum = 0;
                    break;

                case "monday":
                    userInputCovertNum = 1;
                    break;

                case "tuesday":
                    userInputCovertNum = 2;
                    break;

                case "wednesday":
                    userInputCovertNum = 3;
                    break;

                case "thursday":
                    userInputCovertNum = 4;
                    break;

                case "friday":
                    userInputCovertNum = 5;
                    break;

                case "saturday":
                    userInputCovertNum = 6;
                    break;
                default:
                    userInputCovertNum = 7;
                    break;
            }

            return (Week)userInputCovertNum;
        }

    }
}
