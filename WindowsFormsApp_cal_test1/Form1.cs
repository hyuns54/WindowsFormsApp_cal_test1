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

        private void Number_Click(object sender, EventArgs e) // 숫자 버튼 클릭 이벤트
        {
            Button button = (Button)sender; //클릭된 버튼 가져옴
            if (display.Text == "0" || isOperationClicked ) //텍스트가 0이거나 거짓의 연산자가 클릭 되었을 때
            {
                display.Text = ""; // 아무것도 띄우지 않음
            }
            isOperationClicked = false; //연산자 클릭 초기화
            display.Text += button.Text; //버튼의 텍스트를 결과창에 띄움
        }
        private void Operation_Click(object sender, EventArgs e) //연산자 버튼 클릭 이벤트
        {
            Button button = (Button)sender; // 클릭된 버튼 가져옴
            cOperation = button.Text; //오퍼레이터라는 변수에 버튼의 텍스트 대입
            cValue = double.Parse(display.Text); //변수를 결과창에 실수로 대입
            isOperationClicked = true; //연산자 클릭 초기화
            display.Text = cValue.ToString() + " " + cOperation; //결과창에 실수와 연산자 띄움
        }
        private void Btn_Point_Click(object sender, EventArgs e)
        {
            if(!display.Text.Contains(".")) //
            {
                display.Text += ".";
            }
        }
        private void Btn_Result_Click(object sender, EventArgs e)
        {
            double seconValue = double.Parse(display.Text);
            switch (cOperation)
            {
                case "+":
                    display.Text = (cValue + seconValue).ToString();
                    break;
                case "-":
                    display.Text = (cValue - seconValue).ToString();
                    break;
                case "*":
                    display.Text = (cValue * seconValue).ToString();
                    break;
                case "/":
                    if(seconValue != 0 )
                    {
                        display.Text = (cValue / seconValue).ToString();

                    }
                    else
                    {
                        display.Text = "입력이 잘못 되었습니다.";
                    }
                    break;

            }
            cValue = double.Parse(display.Text);
        }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "1";
        }
    }
}
