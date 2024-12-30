using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_vendingMachine
{
    public class User
    {
        private VendingMachine vendingMachine;
        private TextBox textBox_userHaveMoney;
        private TextBox textBox_insertedMoney;
        private TextBox textBox_boughtDrink;

        public User(VendingMachine vendingMachine, TextBox textBox_userHaveMoney, TextBox textBox_insertedMoney, TextBox textBox_boughtDrink)
        {
            this.vendingMachine = vendingMachine;
            this.textBox_userHaveMoney = textBox_userHaveMoney;
            this.textBox_insertedMoney = textBox_insertedMoney;
            this.textBox_boughtDrink = textBox_boughtDrink;
        }

        private int holdingMoney;
        private int receiveChangeMoney;
        private int boughtDrinkCount;

        public int HoldingMoney
        {
            get { return holdingMoney; }
            set { holdingMoney = value; }
        }
        public int ReceiveChangeMoney
        {
            get { return receiveChangeMoney; }
            set { receiveChangeMoney = value; }
        }

        // 자판기에 돈 넣기
        public void insertMoney(int paidMoney)
        {
            textBox_insertedMoney.ForeColor = Color.Black;
            if (holdingMoney >= 1000)
            {
                holdingMoney = holdingMoney - paidMoney;
                vendingMachine.ReceiveMoney += 1000;

                textBox_userHaveMoney.Text = HoldingMoney.ToString();
                textBox_insertedMoney.Text = vendingMachine.ReceiveMoney.ToString();
            }
            else if (holdingMoney > 0 || holdingMoney < 1000)
            {
                vendingMachine.ReceiveMoney += holdingMoney;
                holdingMoney = holdingMoney - holdingMoney;                

                textBox_userHaveMoney.Text = holdingMoney.ToString();
                textBox_insertedMoney.Text = vendingMachine.ReceiveMoney.ToString();
            }
            else
            {
                MessageBox.Show("돈이 없어..");
            }
        }

        // 음료 선택하기
        public void clickDrinkButton()
        {
            vendingMachine.compareReceiveAndDrinkPrice();
        }

        // 거스름 돈 받기
        public void returnChangeMoney()
        {
            int returnedChange = vendingMachine.returnChange();

            holdingMoney += returnedChange;
            textBox_userHaveMoney.Text = holdingMoney.ToString();
            textBox_insertedMoney.Text = vendingMachine.ReceiveMoney.ToString();
        }

        // 구매한 음료 회수
        public void returnBounghtDrink()
        {
            boughtDrinkCount = vendingMachine.ReturnDrinkCount;
            textBox_boughtDrink.Text = boughtDrinkCount.ToString();
        }
    }
}
