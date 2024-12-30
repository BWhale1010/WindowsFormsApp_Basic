using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_vendingMachine
{
    public class Manager
    {
        private VendingMachine vendingMachine;
        private TextBox textBox_mcDrinkCount;
        private TextBox textBox_mcHaveMoney;
        private TextBox textBox_mgHaveMoney;
        private TextBox textBox_drinkPriceChange;
        private Label label_drinkPrice;

        public Manager(VendingMachine vendingMachine, TextBox textBox_mcDrinkCount, TextBox textBox_mcHaveMoney, 
            TextBox textBox_mgHaveMoney, TextBox textBox_drinkPriceChange, Label label_drinkPrice)
        {
            this.vendingMachine = vendingMachine;
            this.textBox_mcDrinkCount = textBox_mcDrinkCount;
            this.textBox_mcHaveMoney = textBox_mcHaveMoney;
            this.textBox_mgHaveMoney = textBox_mgHaveMoney;
            this.textBox_drinkPriceChange = textBox_drinkPriceChange;
            this.label_drinkPrice = label_drinkPrice;
        }

        int supplementDrink = 10;
        int collectMoney = 1000;
        int managerHaveMoney = 10000;
        
        public int ManagerHaveMoney
        {
            get { return managerHaveMoney; }
            set { managerHaveMoney = value; }
        }

        // 음료 보충
        public void supplyDrink()
        {
            if (vendingMachine.RemainDrinkCount <= 90)
            {
                vendingMachine.RemainDrinkCount += supplementDrink;
                textBox_mcDrinkCount.Text = vendingMachine.RemainDrinkCount.ToString();
                vendingMachine.machineMessageShow("정상");
            }
            else
            {
                MessageBox.Show("음료를 100개 초과 보관할 수 없습니다.");
            }
        }

        // 자판기 수익 회수
        public void takeProfits()
        {
            if (vendingMachine.VendingMachineRemainMoney >= collectMoney)
            {
                vendingMachine.VendingMachineRemainMoney -= collectMoney;
                ManagerHaveMoney += collectMoney;
                textBox_mcHaveMoney.Text = vendingMachine.VendingMachineRemainMoney.ToString();
                textBox_mgHaveMoney.Text = ManagerHaveMoney.ToString();
            }
            else
            {
                MessageBox.Show("회수할 돈이 없습니다.");
            }
        }

        // 거스름돈 보충하기
        public void supplyChangeMoney()
        {
            if (ManagerHaveMoney >= collectMoney)
            {
                vendingMachine.VendingMachineRemainMoney += collectMoney;
                ManagerHaveMoney -= collectMoney;
                textBox_mcHaveMoney.Text = vendingMachine.VendingMachineRemainMoney.ToString();
                textBox_mgHaveMoney.Text = ManagerHaveMoney.ToString();
            }
            else
            {
                MessageBox.Show("충전할 돈이 없습니다.");
            }
        }

        // 자판기 음료 가격 변경
        public void changeDrinkPrice()
        {
            if (!int.TryParse(textBox_drinkPriceChange.Text, out _))
            {
                MessageBox.Show("숫자만 가능!");
                textBox_drinkPriceChange.Text = String.Empty;
            }
            else
            {
                vendingMachine.DrinkPrice = int.Parse(textBox_drinkPriceChange.Text);
                label_drinkPrice.Text = vendingMachine.DrinkPrice + "원";
            }
        }

    }
}
