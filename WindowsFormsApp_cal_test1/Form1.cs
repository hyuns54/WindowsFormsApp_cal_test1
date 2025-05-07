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
        // 사용자가 입력 중인 숫자를 저장합니다.
        private string currentInput = "";

        // 전체 계산식을 저장합니다 (예: "1 + 2 *").
        private string expression = "";

        // 결과가 방금 표시되었는지 여부를 저장합니다.
        private bool isResultJustShown = false;

        // 폼이 생성될 때 자동으로 실행되는 생성자입니다.
        public Form1()
        {
            InitializeComponent(); // 폼에 있는 버튼, 텍스트박스 등을 초기화합니다.
            AssignButtonEvents();  // 버튼들이 클릭되었을 때 어떤 동작을 할지 연결합니다.
        }

        // 모든 버튼에 클릭 이벤트를 연결하는 함수입니다.
        private void AssignButtonEvents()
        {
            // 숫자 버튼을 누르면 해당 숫자를 입력창에 추가합니다.
            Btn_0.Click += (s, e) => AppendToCurrentInput("0");
            Btn_1.Click += (s, e) => AppendToCurrentInput("1");
            Btn_2.Click += (s, e) => AppendToCurrentInput("2");
            Btn_3.Click += (s, e) => AppendToCurrentInput("3");
            Btn_4.Click += (s, e) => AppendToCurrentInput("4");
            Btn_5.Click += (s, e) => AppendToCurrentInput("5");
            Btn_6.Click += (s, e) => AppendToCurrentInput("6");
            Btn_7.Click += (s, e) => AppendToCurrentInput("7");
            Btn_8.Click += (s, e) => AppendToCurrentInput("8");
            Btn_9.Click += (s, e) => AppendToCurrentInput("9");

            // 연산자 버튼을 누르면 수식에 연산 기호를 추가합니다.
            Btn_Add.Click += (s, e) => AppendToExpression("+");
            Btn_Subtract.Click += (s, e) => AppendToExpression("-");
            Btn_Multiply.Click += (s, e) => AppendToExpression("*");
            Btn_Divide.Click += (s, e) => AppendToExpression("/");

            // 소수점(.) 버튼을 누를 때 처리
            Btn_Point.Click += Btn_Point_Click;

            // = 버튼 (결과 계산 버튼)을 누를 때 처리
            Btn_Result.Click += Btn_Result_Click;

            // 전체 초기화 버튼 (C) - 수식과 입력을 모두 지웁니다.
            Btn_Clear.Click += (s, e) =>
            {
                expression = "";
                currentInput = "";
                display.Clear(); // 화면도 비웁니다.
            };

            // 현재 입력만 초기화 (CE) - 예: "3 + 5" 에서 5만 지우고 싶을 때 사용
            Btn_ClearEntry.Click += (s, e) =>
            {
                currentInput = "";
                UpdateDisplay(); // 화면만 다시 보여줍니다.
            };
        }

        // 소수점(.) 버튼을 눌렀을 때 동작
        private void Btn_Point_Click(object sender, EventArgs e)
        {
            // 이미 소수점이 들어간 경우에는 또 추가하지 않도록 막습니다.
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                UpdateDisplay();
            }
        }

        // = 버튼을 눌렀을 때 동작 (계산 결과 보여주기)
        private void Btn_Result_Click(object sender, EventArgs e)
        {
            try
            {
                // 입력 중인 숫자도 수식에 포함시킵니다.
                expression += currentInput;

                // 전체 수식을 계산합니다. 예: "1 + 2 * 3"
                var result = new DataTable().Compute(expression, null);

                // 결과를 currentInput에 저장해서 화면에 보여줄 수 있게 합니다.
                currentInput = result.ToString();

                // 화면에 결과와 수식을 함께 보여줍니다.
                UpdateDisplay(showResult: true, originalExpression: expression);

                // 계산한 후엔 수식을 초기화합니다.
                expression = "";

                // 지금 표시된 게 계산 결과라는 걸 표시합니다.
                isResultJustShown = true;
            }
            catch
            {
                // 계산 도중 오류가 나면 에러 메시지를 보여줍니다.
                display.Text = "Error";
            }
        }

        // +, -, *, / 같은 연산자 버튼을 눌렀을 때 처리하는 함수입니다.
        private void AppendToExpression(string op)
        {
            if (isResultJustShown)
            {
                // 이전에 계산 결과가 나왔고, 그 다음에 연산자를 눌렀다면
                // 새 계산을 시작하기 위해 결과 값을 새 수식의 시작으로 씁니다.
                expression = currentInput + " ";
                isResultJustShown = false;
            }
            else if (!string.IsNullOrEmpty(currentInput))
            {
                // 결과 직후가 아닌 경우, 지금 입력 중인 숫자를 수식에 추가합니다.
                expression += currentInput + " ";
            }

            // 연산자가 중복되는 것을 막기 위한 처리입니다.
            string trimmed = expression.TrimEnd();
            if (trimmed.EndsWith("+") || trimmed.EndsWith("-") ||
                trimmed.EndsWith("*") || trimmed.EndsWith("/"))
            {
                // 마지막 연산자를 지웁니다.
                expression = trimmed.Substring(0, trimmed.Length - 1);
            }

            // 새로운 연산자를 수식에 추가합니다.
            expression = expression.TrimEnd() + " " + op + " ";
            currentInput = ""; // 숫자 입력은 새로 시작해야 하므로 초기화합니다.
            UpdateDisplay();
        }

        // 숫자를 누를 때마다 현재 입력값에 이어 붙이는 함수입니다.
        private void AppendToCurrentInput(string val)
        {
            if (isResultJustShown)
            {
                // 계산 결과를 본 다음 숫자를 누르면 새로운 계산을 시작합니다.
                currentInput = val;
                expression = "";
                isResultJustShown = false;
            }
            else
            {
                // 기존 숫자 입력에 숫자를 추가합니다.
                currentInput += val;
            }

            UpdateDisplay(); // 화면 갱신
        }

        // 화면에 계산식과 현재 입력 숫자를 보여주는 함수입니다.
        private void UpdateDisplay(bool showResult = false, string originalExpression = "")
        {
            if (showResult)
            {
                // 결과를 표시할 때: 위에는 수식, 아래에는 결과
                display.Text = originalExpression + Environment.NewLine + currentInput;
            }
            else
            {
                // 입력 중일 때: 위에는 수식, 아래에는 지금 입력 중인 숫자
                display.Text = expression + Environment.NewLine +
                    (string.IsNullOrEmpty(currentInput) ? " " : currentInput);
            }
        }
    }
}
