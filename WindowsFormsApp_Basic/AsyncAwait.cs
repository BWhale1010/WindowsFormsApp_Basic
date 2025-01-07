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
    public partial class AsyncAwait : Form
    {
        public AsyncAwait()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await ReadFileAsync();
        }

        async Task ReadFileAsync()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string fileName = "";
            string result = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;

                using (StreamReader streamReader = File.OpenText(fileName))
                {
                    result = await streamReader.ReadToEndAsync();
                }

                textBox1.Text = result;
            }
        }
    }
}
