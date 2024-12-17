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
    public partial class StringAndArray : Form
    {
        public StringAndArray()
        {
            InitializeComponent();

            string[] stringArray = new string[10];
            string[] subArray = new string[3];

            stringArray[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            stringArray[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            stringArray[2] = "질서있는 퇴장".Contains("퇴").ToString();
            stringArray[3] = "그 사람의 그림자는 그랬다.".Replace("그", "이").ToString();
            stringArray[4] = "삼성 갤럭시".Insert(3, "애플").ToString();
            stringArray[5] = "오늘은 왠지 더 배고프다".Remove(6,2).ToString();
            //char[] splitChar = new char[2] { ',', ' '};
            subArray = "이름, 나이, 전화번호".Split(new char[2] { ',', ' '}, 3, StringSplitOptions.RemoveEmptyEntries);
            stringArray[6] = subArray[0].ToString();
            stringArray[7] = subArray[1].ToString();
            stringArray[8] = subArray[2].ToString();
            stringArray[9] = "우리 나라 만세".Substring(3, 2).ToString();

            textBox_print.Text = stringArray[0];
            textBox_print.Text += "\r\n";
            textBox_print.Text += stringArray[1];
            textBox_print.Text += "\r\n";
            textBox_print.Text += stringArray[2];
            textBox_print.Text += "\r\n";
            textBox_print.Text += stringArray[3];
            textBox_print.Text += "\r\n";
            textBox_print.Text += stringArray[4];
            textBox_print.Text += "\r\n";
            textBox_print.Text += stringArray[5];
            textBox_print.Text += "\r\n";
            textBox_print.Text += stringArray[6];
            textBox_print.Text += "\r\n";
            textBox_print.Text += stringArray[7];
            textBox_print.Text += "\r\n";
            textBox_print.Text += stringArray[8];
            textBox_print.Text += "\r\n";
            textBox_print.Text += stringArray[9];
        }
    }
}
