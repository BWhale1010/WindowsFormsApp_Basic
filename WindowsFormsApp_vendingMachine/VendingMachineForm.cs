using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_vendingMachine
{
    public partial class VendingMachineForm : Form
    {
        private User user;
        private VendingMachine vendingMachine;
        private Manager manager;

        struct VendingMachineInitialStatus
        {
            internal int machineStatusNum;
        }

        public VendingMachineForm()
        {
            InitializeComponent();

            // 버튼 음료 이미지삽입
            button_drink.BackgroundImage = Image.FromFile(@"F:\문서\cider.jpg");
            button_drink.BackgroundImageLayout = ImageLayout.Stretch;

            // 클래스, 구조체 객체 생성
            vendingMachine = new VendingMachine(textBox_insertedMoney, textBox_boughtDrink, label_machineStatus);
            user = new User(vendingMachine, textBox_userHaveMoney, textBox_insertedMoney, textBox_boughtDrink);
            manager = new Manager(vendingMachine, textBox_mcDrinkCount, textBox_mcHaveMoney, textBox_mgHaveMoney, textBox_drinkPriceChange, label_drinkPrice);
            VendingMachineInitialStatus machineInitialStatus = new VendingMachineInitialStatus();

            // 음료 가격 label
            label_drinkPrice.Text = vendingMachine.DrinkPrice + "원";

            // 자판기 상태 초기화 
            machineInitialStatus.machineStatusNum = vendingMachine.CheckMachineStatus();
            string labelMessage = "";

            // 자판기 초기화별 안내 메세지, 버튼 제어
            if (machineInitialStatus.machineStatusNum == 1) 
            {
                label_machineStatus.ForeColor = Color.Red;
                labelMessage = "잔돈이 부족합니다. 관리자를 호출하세요.";
                vendingMachine.machineMessageShow(labelMessage);
                button_drink.Enabled = false;
            }
            else if (machineInitialStatus.machineStatusNum == 2)
            {

                label_machineStatus.ForeColor = Color.Red;
                labelMessage = "음료가 부족합니다. 관리자를 호출하세요.";
                vendingMachine.machineMessageShow(labelMessage);
                button_drink.Enabled = false;
            }
            else 
            {
                label_machineStatus.Text = "정상";
            }

            // 유저 상태 초기화
            user.HoldingMoney = 3000;
            textBox_userHaveMoney.Text = user.HoldingMoney.ToString();
        }

    }
}
