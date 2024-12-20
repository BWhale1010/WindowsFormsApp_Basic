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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            
            int inputStudentNum;

            if (int.TryParse(textBox_input.Text, out inputStudentNum))
            {
                int[,] subjectAndScoreArray = new int[inputStudentNum, 4];

                for (int i = 0; i < inputStudentNum; i++)
                {
                    Random random = new Random();
                    subjectAndScoreArray[i, 0] = i+1;
                   for(int j = 1; j<4; j++)
                    {
                        
                        subjectAndScoreArray[i, j] = random.Next(0, 101);
                    }
                }

                insertData(subjectAndScoreArray);
            }
            else
            {
                MessageBox.Show("숫자만 입력");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("colname", "이름");
            dataGridView1.Columns.Add("colsubject1", "국어");
            dataGridView1.Columns.Add("colsubject2", "영어");
            dataGridView1.Columns.Add("colsubject3", "수학");
        }

        void insertData(int[,] subjectAndScoreArray)
        {
            dataGridView1.Rows.Clear();

            int arrayCount = subjectAndScoreArray.GetLength(0);

            for (int k = 0; k < arrayCount; k++)
            {
                dataGridView1.Rows.Add("학생" + (k+1), subjectAndScoreArray[0, 1], subjectAndScoreArray[0, 2], subjectAndScoreArray[0, 3]);
            }
            
        }
    }
}
