using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Basic
{
    public partial class Collection : Form
    {
        List<string> list = new List<string>();
        Dictionary<string, string> idPassDic = new Dictionary<string, string>();
        Dictionary<string, string> idCallNumDic = new Dictionary<string, string>();

        public Collection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                Stream fileStream = openFileDialog.OpenFile();

                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string line;

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        list.Clear();

                        string[] strVal = line.Split(',');
                        foreach (string str in strVal)
                        {
                            list.Add(str);
                        }

                        idPassDic.Add(list[0], list[1]);
                        if (list.Count() == 2)
                        {
                            idCallNumDic.Add(list[0], null);
                        }
                        else
                        {
                            idCallNumDic.Add(list[0], list[2]);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = "";
            string callNum = "";

            if (idPassDic.ContainsKey(textBox_id.Text) && idPassDic.TryGetValue(textBox_id.Text, out password))
            {
                if (password.Equals(textBox_password.Text))
                {
                    idCallNumDic.TryGetValue(textBox_id.Text, out callNum);
                    try
                    {
                        MessageBox.Show("아이디 : " + textBox_id.Text + "\r\n전화번호 : " + callNum.ToString());
                    }
                    catch(NullReferenceException) 
                    {
                        MessageBox.Show("아이디 : " + textBox_id.Text + "\r\n전화번호 : 없음");
                    }
                    //catch(Exception ex) 
                    //{
                    //    MessageBox.Show(ex.Message);
                    //}
                    
                }
            }
            else
            {
                MessageBox.Show("아이디와 비밀번호가 틀렸습니다.");
            }
        }


    }
}
