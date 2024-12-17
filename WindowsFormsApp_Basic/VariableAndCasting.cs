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
    public partial class VariableAndCasting : Form
    {
        public VariableAndCasting()
        {
            InitializeComponent();

            // 슬랙 멤버 수
            byte memberCountInSlack = 27;
            // 우리나라 전역의 지하철 역 개수
            short subwayStationsCountOfKorea = 1100;
            // 유럽의 인구 수
            int populationOfEurope = 745173774;
            // 서울의 인구 밀도
            float populationDensityInSeoul = 15425.47f;
            // 서울의 경도
            double longitudeOfSeoul = 126.978445d;
            // 안드로메다 은하의 별의 개수
            decimal starsCountInAndromeda = 1000000000000;

            textBox_print.Text += memberCountInSlack.GetType()+" : ";
            textBox_print.Text += memberCountInSlack.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += subwayStationsCountOfKorea.GetType() + " : ";
            textBox_print.Text += subwayStationsCountOfKorea.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += populationOfEurope.GetType() + " : ";
            textBox_print.Text += populationOfEurope.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += populationDensityInSeoul.GetType() + " : ";
            textBox_print.Text += populationDensityInSeoul.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += longitudeOfSeoul.GetType() + " : ";
            textBox_print.Text += longitudeOfSeoul.ToString();
            textBox_print.Text += "\r\n";
            textBox_print.Text += starsCountInAndromeda.GetType() + " : ";
            textBox_print.Text += starsCountInAndromeda.ToString();
        }
    }
}
