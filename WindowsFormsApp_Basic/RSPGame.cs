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
    public partial class RSPGame : Form
    {
        public int userInput = 0;
        public int userWin = 0;
        public int computerWin = 0;

        enum GameChoice { 
            가위,
            바위,
            보
        }

        public RSPGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userInput = 1;
            gameCompare(userInput);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userInput = 2;
            gameCompare(userInput);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userInput = 3;
            gameCompare(userInput);
        }

        void gameCompare(int userInput)
        {
            if (userWin <3 && computerWin <3)
            {
                textBox1.Text = "";
                int computerChoice = computerGen();
                GameChoice enumComputerChoice = convertToEnum(computerChoice);
                GameChoice enumUserChoice = convertToEnum(userInput);

                switch (enumComputerChoice)
                {
                    case GameChoice.가위:
                        textBox1.Text += "컴퓨터는 가위\r\n";
                        if (enumUserChoice == GameChoice.가위)
                        {
                            textBox1.Text += "사용자는 "+GameChoice.가위+"\r\n";
                            textBox1.Text += "비겼습니다.\r\n";
                        }
                        else if (enumUserChoice == GameChoice.바위)
                        {
                            textBox1.Text += "사용자는 "+GameChoice.바위+"\r\n";
                            textBox1.Text += "이겼습니다.\r\n";
                            userWin++;
                        }
                        else if (enumUserChoice == GameChoice.보)
                        {
                            textBox1.Text += "사용자는 " + GameChoice.보 + "\r\n";
                            textBox1.Text += "졌습니다.\r\n";
                            computerWin++;
                        }
                        break;
                    case GameChoice.바위:
                        textBox1.Text += "컴퓨터는 바위\r\n";
                        if (userInput == 1)
                        {
                            textBox1.Text += "사용자는 " + GameChoice.가위 + "\r\n";
                            textBox1.Text += "졌습니다.\r\n";
                            computerWin++;
                        }
                        else if (userInput == 2)
                        {
                            textBox1.Text += "사용자는 " + GameChoice.바위 + "\r\n";
                            textBox1.Text += "비겼습니다.\r\n";
                        }
                        else if (userInput == 3)
                        {
                            textBox1.Text += "사용자는 " + GameChoice.보 + "\r\n";
                            textBox1.Text += "이겼습니다.\r\n";
                            userWin++;
                        }
                        break;
                    case GameChoice.보:
                        textBox1.Text += "컴퓨터는 보\r\n";
                        if (userInput == 1)
                        {
                            textBox1.Text += "사용자는 " + GameChoice.가위 + "\r\n";
                            textBox1.Text += "이겼습니다.\r\n";
                            userWin++;
                        }
                        else if (userInput == 2)
                        {
                            textBox1.Text += "사용자는 " + GameChoice.바위 + "\r\n";
                            textBox1.Text += "졌습니다.\r\n";
                            computerWin++;
                        }
                        else if (userInput == 3)
                        {
                            textBox1.Text += "사용자는 " + GameChoice.보 + "\r\n";
                            textBox1.Text += "비겼습니다.\r\n";
                        }
                        break;
                }

                textBox1.Text += "컴퓨터 : " + computerWin + " / 사용자 : " + userWin + "\r\n";
            }
            else
            {
                if(userWin > computerWin)
                {
                    textBox1.Text += "사용자가 승리했습니다.";
                }
                else
                {
                    textBox1.Text += "컴퓨터가 승리했습니다.";
                }
            }
                
        }

        int computerGen()
        {
            int computerChoice = 0;
            Random rand = new Random();

            int randomNum = rand.Next(0,3);

            switch (randomNum)
            {
                case 0:
                    computerChoice = 1;
                    break;
                case 1:
                    computerChoice = 2;
                    break;
                case 2:
                    computerChoice = 3;
                    break;
            }

            return computerChoice;
        }

        GameChoice convertToEnum(int inputInt)
        {
            GameChoice enumChoice = 0;

            switch (inputInt)
            {
                case 1:
                    enumChoice = GameChoice.가위;
                    break;
                case 2:
                    enumChoice = GameChoice.바위;
                    break;
                case 3:
                    enumChoice = GameChoice.보;
                    break;
            }

            return enumChoice;
        }
    }
}
