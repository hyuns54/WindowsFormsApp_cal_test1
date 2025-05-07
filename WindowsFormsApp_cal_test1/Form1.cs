using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_cal_test1
{
    public partial class Form1 : Form
    {
            double cValue = 0; // cVALUE라는 변수에 0 대입
            string cOperation = ""; // cOperation이라는 변수에 "" 대입
        bool isOperationClicked = false; // 연산자가 클릭되었는지 확인하는 변수

        public Form1()
        {
            InitializeComponent();
            display.Text = "0";

        }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "1";
        }
    }
}
