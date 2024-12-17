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
    public partial class String : Form
    {
        public String()
        {
            InitializeComponent();

            string msg = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";

            // 1
            int indexNum = msg.IndexOf("-");
            string newMsg1 = msg.Remove(indexNum).ToString();

            // 2
            int startIndex = msg.IndexOf("얼마나");
            int endIndex = msg.LastIndexOf("가는지") + "가는지".Length;
            string subMsg = msg.Substring(startIndex, endIndex - startIndex);
            string[] newMsg2 = subMsg.Split(' ');

            // 3
            string newMsg3 = msg.Replace(".", "").Replace("-", "");
            newMsg3 = newMsg3.Replace(" ", ",");

            textBox_print.Text = newMsg1 + "\r\n";
            textBox_print.Text += newMsg2[0] + "\r\n";
            textBox_print.Text += newMsg2[1] + "\r\n";
            textBox_print.Text += newMsg2[2] + "\r\n";
            textBox_print.Text += newMsg3;


        }
    }
}
