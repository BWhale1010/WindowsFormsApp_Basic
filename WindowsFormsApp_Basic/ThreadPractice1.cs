using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp_Basic
{
    public partial class ThreadPractice1 : Form
    {
        BackgroundWorker worker;
        FolderBrowserDialog dialog;
        string selectedPath = "";
        string fileType = "";

        public ThreadPractice1()
        {
            InitializeComponent();

            this.worker = new BackgroundWorker();
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;

            this.worker.DoWork += Worker_DoWork;
            this.worker.ProgressChanged += Worker_ProgressChanged;
            this.worker.RunWorkerCompleted += Worker_Complete;
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            dialog = new FolderBrowserDialog();
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedPath = dialog.SelectedPath;
                textBox1.Text = selectedPath;
                fileType = textBox2.Text;

                listBox1.Items.Clear();

                if (!this.worker.IsBusy)
                {
                    this.worker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("작업이 이미 진행 중입니다.");
                }
            }
        }

        void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (string.IsNullOrEmpty(selectedPath) || string.IsNullOrEmpty(fileType))
            {
                e.Result = "디렉토리 경로 및 파일 유형이 올바르지 않습니다.";
                return;
            }

            if (!Directory.Exists(selectedPath))
            {
                e.Result = "해당 디렉토리가 없습니다.";
                return;
            }

            DirectoryInfo dir = new DirectoryInfo(selectedPath);

            foreach (FileInfo file in dir.GetFiles())
            {
                if (file.Extension.Equals("." + fileType))
                {
                    this.worker.ReportProgress(0, file.Name);
                }
            }

            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                foreach (FileInfo file in subDir.GetFiles())
                {
                    if (file.Extension.Equals("." + fileType))
                    {
                        this.worker.ReportProgress(0, file.Name);
                    }
                }
            }

            e.Result = "검색을 완료했습니다.";
        }

        void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is string fileName)
            {
                listBox1.Items.Add(fileName);
            }
        }

        void Worker_Complete(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is string result)
            {
                MessageBox.Show(result);
            }
        }
    }
}
