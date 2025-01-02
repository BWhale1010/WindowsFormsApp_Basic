using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp_Basic
{
    public partial class TryCatch : Form
    {
        public TryCatch()
        {
            InitializeComponent();
            mainMethod();
        }

        public void mainMethod()
        {
            string[] seperateStr = new string[] { "\r\n" };
            string[] strArray;

            string content = "";

            try
            {
                content = File.ReadAllText(@"F:\\file.txt");
                
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("IoException"+ioEx.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception" + ex.Message);
            }
            finally
            {
                strArray = outArray(out strArray, content, seperateStr);
            }

            for(int i = 0; i < strArray.Length; i++)
            {
                int[] intArray = new int[5];
                try
                {
                    intArray[i] = int.Parse(strArray[i]); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception" + ex.Message);
                }
                finally
                {
                    textBox1.Text += intArray[i].ToString()+"\r\n";
                    
                }
            }
        }

        public string[] outArray(out string[] outStrArray, string content, string[] seperateStr)
        {
            outStrArray = content.Split('\n');

            return outStrArray;
        }
    }
}
