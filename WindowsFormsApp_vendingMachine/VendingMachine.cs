using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_vendingMachine
{
    public class VendingMachine
    {
        int receiveMoney = 0;
        int drinkPrice = 800;
        int remainDrinkCount = 2;
        bool drinkCountCheck = false;
        int vendingMachineRemainMoney = 5000;
        int returnDrinkCount = 0;

        private TextBox textBox_insertedMoney;
        private TextBox textBox_boughtDrink;
        private Label label_machineStatus;

        public VendingMachine(TextBox textBox_insertedMoney, TextBox textBox_boughtDrink, Label label_machineStatus)
        {
            this.textBox_insertedMoney = textBox_insertedMoney;
            this.textBox_boughtDrink = textBox_boughtDrink;
            this.label_machineStatus = label_machineStatus;
        }

        enum VendingMachineStatus
        {
            Normal = 0,
            NotEnoughChange = 1,
            NotEnoughDrink = 2
        }

        public int ReceiveMoney
        {
            get { return receiveMoney; }
            set { receiveMoney = value; }
        }

        public int RemainDrinkCount
        {
            get { return remainDrinkCount; }
            set { remainDrinkCount = value; }
        }

        public int VendingMachineRemainMoney
        {
            get { return vendingMachineRemainMoney; }
            set { vendingMachineRemainMoney = value; }
        }

        public int DrinkPrice
        {
            get { return drinkPrice; }
            set {  drinkPrice = value; }
        }

        public int ReturnDrinkCount 
        {
            get { return returnDrinkCount; }
            set { returnDrinkCount = value; } 
        }

        // 자판기 초기 상태 확인
        public int CheckMachineStatus()
        {
            string statusStr = "";
            int statusVal = 0;

            if (vendingMachineRemainMoney < 200)
            {
                statusStr = "NotEnoughChange";

                if (Enum.TryParse<VendingMachineStatus>(statusStr, out VendingMachineStatus status))
                {
                    statusVal = (int)status;
                }
            }
            else if (remainDrinkCount < 1)
            {
                statusStr = "NotEnoughDrink";

                if (Enum.TryParse<VendingMachineStatus>(statusStr, out VendingMachineStatus status))
                {
                    statusVal = (int)status;
                }
            }

            return statusVal;
        }
        // 받은 돈과 음료 가격 비교
        public void compareReceiveAndDrinkPrice()
        {
            if (checkDrinkCount())
            {
                if (ReceiveMoney >= DrinkPrice)
                {
                    throwDrink();
                    ReceiveMoney -= DrinkPrice;
                    VendingMachineRemainMoney += DrinkPrice;
                    textBox_insertedMoney.Text = ReceiveMoney.ToString();
                }
                else
                {
                    textBox_insertedMoney.ForeColor = Color.Red;
                    textBox_insertedMoney.Text = "잔액 부족";
                }
            }
            else
            {
                label_machineStatus.ForeColor = Color.Red;
                string labelMessage = "음료가 부족합니다. 관리자를 호출하세요.";
                machineMessageShow(labelMessage);
            }
        }
        // 음료 개수 확인
        bool checkDrinkCount()
        {
            if(remainDrinkCount > 0)
            {
                drinkCountCheck = true;
            }
            else
            {
                drinkCountCheck = false;
            }
            return drinkCountCheck;
        }
        // 거스름돈 반환
        public int returnChange()
        {
            if (receiveMoney <= vendingMachineRemainMoney)
            {
                int returnMoney = receiveMoney;
                receiveMoney = 0;

                return returnMoney;
            }
            else
            {
                string labelMessage = "잔돈이 부족합니다. 관리자를 호출하세요.";
                machineMessageShow(labelMessage);
                return 0;
            }

        }
        // 음료 개수 차감(음료투하)
        public void throwDrink()
        {
            remainDrinkCount = --remainDrinkCount;
            returnDrinkCount = ++returnDrinkCount;
        }

        // 자판기 상태 메세지 출력
        public void machineMessageShow(string labelMessage)
        {
            label_machineStatus.Text = labelMessage;

            if (labelMessage.Equals("정상"))
            {
                label_machineStatus.ForeColor = Color.Blue;
            }

        }

    }
}
