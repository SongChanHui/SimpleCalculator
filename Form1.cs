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
            txtResult.Text = "0";
            isNewInput = true;
            UpdateRealTimeFormula(); // ★ 추가: 위에 적힌 999도 같이 사라짐
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            }
            if (string.IsNullOrEmpty(txtResult.Text) || txtResult.Text == "0")
            {
                txtResult.Text = "0";
                isNewInput = true;
            }
            UpdateRealTimeFormula(); // ★ 추가: 지우는 대로 위에도 반영됨 [cite: 587-588]
        }
    }
}
    