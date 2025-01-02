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
    public partial class RefOut : Form
    {
        int[] refArray = new int[10];
        int[] outArray;

        public RefOut()
        {
            InitializeComponent();

            RefMethod(ref refArray);
            OutMethod(out outArray);
        }

        public void RefMethod(ref int[] refArray)
        {
            int j = 1;
            for (int i = 0; i < refArray.Length; i++)
            {
                refArray[i] = j++;
            }


        }

        public void OutMethod(out int[] outArray)
        {
            outArray = new int[10];

            int j = 1;
            for (int i = 1; i < outArray.Length; i++)
            {
                outArray[i] = j++;
            }
        }
    }
}