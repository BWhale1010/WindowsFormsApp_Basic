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
    public partial class If : Form
    {

        public If()
        {
            InitializeComponent();

            bool result = CoinThrow();

            bool userInput = false;

            if (userInput == result)
            {
                textBox_print.Text = "승리";
            }
            else
            {
                textBox_print.Text = "패배";
            }
        }

        bool CoinThrow()
        {

            Random random = new Random();

            int randomNum = random.Next();

            int remainNum = randomNum % 2;

            bool returnTrueFalse = false;

            if(remainNum == 0)
            {
                returnTrueFalse = false;
            }
            else if (remainNum == 1)
            {
                returnTrueFalse = true;
            }

            return returnTrueFalse;

        }
    }
}
