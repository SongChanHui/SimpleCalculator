namespace SimpleCalculator
{
    public partial class FormMain : Form
    {

        double operand1 = 0;
        string currentOperator = "";
        bool isNewInput = true; // 새로운 숫자를 입력할 준비가 되었는지 확인
        public FormMain()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFormula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtResult.Text == "0" || isNewInput)
            {
                txtResult.Text = btn.Text;
                isNewInput = false;
            }
            else
            {
                txtResult.Text += btn.Text;
            }
            UpdateRealTimeFormula(); // ★ 추가: 치는 대로 위에 바로 나옴
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            // 이미 연산자가 있고(예: 12 + 상태), 숫자를 더 입력했다면(예: 34 입력)
            if (currentOperator != "" && isNewInput == false)
            {
                PerformCalculation(); // ★ 위에서 만든 "계산 덩어리"를 실행해라!
            }
            else
            {
                operand1 = double.Parse(txtResult.Text); // 처음 숫자를 저장 [cite: 225]
            }

            currentOperator = "+";
            txtFormula.Text = operand1.ToString() + " + ";
            isNewInput = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (currentOperator == "") return;

            // 1. int 대신 double을 사용하여 소수점 입력을 허용합니다.
            double operand2 = double.Parse(txtResult.Text);
            double result = 0;

            // 2. 모든 계산을 double 타입으로 수행합니다.
            if (currentOperator == "+") result = operand1 + operand2;
            else if (currentOperator == "-") result = operand1 - operand2;
            else if (currentOperator == "x") result = operand1 * operand2;
            else if (currentOperator == "÷")
            {
                // double 연산에서는 5 / 2 가 2.5로 정확히 계산됩니다. 
                if (operand2 != 0) result = operand1 / operand2;
            }

            // 3. 수식창과 결과창 업데이트 (ToString은 그대로 사용 가능) 
            txtFormula.Text = operand1.ToString() + " " + currentOperator + " " + operand2.ToString() + " = " + result.ToString();
            txtResult.Text = result.ToString();

            operand1 = result; // 계산된 실수를 다음 연산을 위해 저장
            currentOperator = "";
            isNewInput = true;
        }

        private void UpdateRealTimeFormula()
        {
            if (currentOperator != "")
            {
                // 예: 25 + 999 처럼 실시간으로 상단에 표시
                txtFormula.Text = operand1.ToString() + " " + currentOperator + " " + txtResult.Text;
            }
            else
            {
                txtFormula.Text = txtResult.Text;
            }
        }

        private void PerformCalculation()
        {
            double operand2 = double.Parse(txtResult.Text);

            if (currentOperator == "+") operand1 += operand2;
            else if (currentOperator == "-") operand1 -= operand2;
            else if (currentOperator == "x") operand1 *= operand2;
            else if (currentOperator == "÷")
            {
                if (operand2 != 0) operand1 /= operand2;
            }
            txtResult.Text = operand1.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (currentOperator != "" && isNewInput == false) PerformCalculation();
            else operand1 = double.Parse(txtResult.Text);

            currentOperator = "-";
            txtFormula.Text = operand1.ToString() + " - ";
            isNewInput = true;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (currentOperator != "" && isNewInput == false) PerformCalculation();
            else operand1 = double.Parse(txtResult.Text);

            currentOperator = "x";
            txtFormula.Text = operand1.ToString() + " x ";
            isNewInput = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (currentOperator != "" && isNewInput == false) PerformCalculation();
            else operand1 = double.Parse(txtResult.Text);

            currentOperator = "÷";
            txtFormula.Text = operand1.ToString() + " ÷ ";
            isNewInput = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            operand1 = 0;          // 저장된 첫 번째 숫자 삭제 [cite: 582]
            currentOperator = "";  // 저장된 연산자 삭제
            txtFormula.Text = "";  // 수식창(56 +) 삭제
            txtResult.Text = "0";  // 결과창 삭제
            isNewInput = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";  // "0"을 지우고 빈 칸으로 만듭니다.
            isNewInput = true;
            UpdateRealTimeFormula();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            }

            // "0"으로 강제 설정하는 로직을 제거했습니다.
            // 마이너스 기호만 남은 경우도 깔끔하게 비워줍니다.
            if (txtResult.Text == "-") txtResult.Text = "";

            isNewInput = (txtResult.Text == ""); // 칸이 비었으면 새로운 입력 상태로 간주
            UpdateRealTimeFormula();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
                isNewInput = false;
            }
            UpdateRealTimeFormula();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "0")
            {
                double val = double.Parse(txtResult.Text); //
                val = val * -1; // 부호 반전
                txtResult.Text = val.ToString(); // [cite: 244]
                UpdateRealTimeFormula();
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            // Shift 키를 눌렀는지 확인 (곱하기 '*' 입력을 위해 필요)
            bool isShift = e.Shift;

            switch (e.KeyCode)
            {
                // 숫자 키 (상단 숫자 D0~D9 및 키패드 NumPad0~NumPad9)
                case Keys.D0: case Keys.NumPad0: button18.PerformClick(); break; // '0' 버튼 이름 반영
                case Keys.D1: case Keys.NumPad1: btnNum1.PerformClick(); break;
                case Keys.D2: case Keys.NumPad2: btnNum2.PerformClick(); break;
                case Keys.D3: case Keys.NumPad3: btnNum3.PerformClick(); break;
                case Keys.D4: case Keys.NumPad4: btnNum4.PerformClick(); break;
                case Keys.D5: case Keys.NumPad5: btnNum5.PerformClick(); break;
                case Keys.D6: case Keys.NumPad6: btnNum6.PerformClick(); break;
                case Keys.D7: case Keys.NumPad7: btnNum7.PerformClick(); break;
                case Keys.D8:
                    if (isShift) btnMulti.PerformClick(); // Shift + 8 = '*' 연산자
                    else btnNum8.PerformClick();
                    break;
                case Keys.D9: case Keys.NumPad9: btnNum9.PerformClick(); break;

                // 연산자 키
                case Keys.Add: btnPlus.PerformClick(); break;                 // 키패드 +
                case Keys.Oemplus: btnPlus.PerformClick(); break;              // 메인 키보드 +
                case Keys.Subtract: case Keys.OemMinus: btnMinus.PerformClick(); break; // -
                case Keys.Multiply: btnMulti.PerformClick(); break;            // 키패드 *
                case Keys.Divide: case Keys.OemQuestion: btnDiv.PerformClick(); break; // / 키 (나누기)

                // 기능 키
                case Keys.Enter: btnEqual.PerformClick(); break;              // '=' 버튼
                case Keys.Back: btnDel.PerformClick(); break;                 // 백스페이스 (Del)
                case Keys.Escape: btnC.PerformClick(); break;                 // ESC 키 (C 버튼)
                case Keys.Decimal: case Keys.OemPeriod: btnDot.PerformClick(); break; // '.' 버튼
            }
        }
    }
}
    