using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_vendingMachine
{
    public partial class VendingMachineForm
    {
        // 음료 선택 클릭
        private void button_drink_Click(object sender, EventArgs e)
        {
            user.clickDrinkButton();
        }

        // 돈 넣기
        private void button_insertMoney_Click(object sender, EventArgs e)
        {
            user.insertMoney(1000);
        }

        // 잔돈 반환 받기
        private void button_returnChange_Click(object sender, EventArgs e)
        {
            user.returnChangeMoney();
        }

        private void button_returnDrink_Click(object sender, EventArgs e)
        {
            user.returnBounghtDrink();
        }

        // 매니저 호출
        private void button_callManager_Click(object sender, EventArgs e)
        {
            button_drinkPriceChange.Enabled = true;
            textBox_mgHaveMoney.Text = manager.ManagerHaveMoney.ToString();
            textBox_mcHaveMoney.Text = vendingMachine.VendingMachineRemainMoney.ToString();
            textBox_mcDrinkCount.Text = vendingMachine.RemainDrinkCount.ToString();
            textBox_drinkPriceChange.Text = vendingMachine.DrinkPrice.ToString();
        }

        // ================ 매니저 기능 ===========================

        // 음료 가격 변경
        private void button_drinkPriceChange_Click(object sender, EventArgs e)
        {
            manager.changeDrinkPrice();
        }

        // 음료 공급
        private void button_drinkSupply_Click(object sender, EventArgs e)
        {
            manager.supplyDrink();
        }

        // 잔돈 공급
        private void button_changeSupply_Click(object sender, EventArgs e)
        {
            manager.supplyChangeMoney();
        }

        // 수익 회수
        private void button_profitGain_Click(object sender, EventArgs e)
        {
            manager.takeProfits();
        }
    }
}
