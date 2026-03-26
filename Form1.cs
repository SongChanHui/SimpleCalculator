namespace SimpleCalculator
{
    public partial class FormMain : Form
    {

        int operand1 = 0;
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

            // 초기 상태(0)거나 새로운 입력 시작이면 지우고 시작
            if (txtResult.Text == "0" || isNewInput)
            {
                txtResult.Text = btn.Text;
                isNewInput = false;
            }
            else
            {
                txtResult.Text += btn.Text; // 숫자를 뒤에 붙임
            }
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
                operand1 = int.Parse(txtResult.Text); // 처음 숫자를 저장 [cite: 225]
            }

            currentOperator = "+";
            txtFormula.Text = operand1.ToString() + " + ";
            isNewInput = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (currentOperator == "") return;

            int operand2 = int.Parse(txtResult.Text); // 두 번째 숫자 변환 
            int result = 0;

            // ★ 이 부분이 빠져있어서 0이 나왔던 겁니다. 모든 연산자를 체크해야 합니다.
            if (currentOperator == "+") result = operand1 + operand2;
            else if (currentOperator == "-") result = operand1 - operand2;
            else if (currentOperator == "x") result = operand1 * operand2;
            else if (currentOperator == "÷")
            {
                // 0으로 나누기 방지 및 정수 나눗셈 규칙 적용 
                if (operand2 != 0) result = operand1 / operand2;
            }

            // 수식창에 전체 과정(예: 12 - 5 = 7)을 표시합니다
            txtFormula.Text = operand1.ToString() + " " + currentOperator + " " + operand2.ToString() + " = " + result.ToString();
            txtResult.Text = result.ToString();

            operand1 = result; // 계산된 결과를 다음 연산의 시작값으로 저장
            currentOperator = ""; // 연산자 초기화
            isNewInput = true;
        }

        private void PerformCalculation()
        {
            int operand2 = int.Parse(txtResult.Text); // 현재 화면의 숫자 가져오기 

            if (currentOperator == "+") operand1 += operand2;
            else if (currentOperator == "-") operand1 -= operand2;
            else if (currentOperator == "x") operand1 *= operand2;
            else if (currentOperator == "÷")
            {
                if (operand2 != 0) operand1 /= operand2; // 0으로 나누기 방지 및 정수 나눗셈
            }

            txtResult.Text = operand1.ToString(); // 계산된 결과를 화면에 표시 
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (currentOperator != "" && isNewInput == false) PerformCalculation();
            else operand1 = int.Parse(txtResult.Text);

            currentOperator = "-";
            txtFormula.Text = operand1.ToString() + " - ";
            isNewInput = true;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (currentOperator != "" && isNewInput == false) PerformCalculation();
            else operand1 = int.Parse(txtResult.Text);

            currentOperator = "x";
            txtFormula.Text = operand1.ToString() + " x ";
            isNewInput = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (currentOperator != "" && isNewInput == false) PerformCalculation();
            else operand1 = int.Parse(txtResult.Text);

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
            txtResult.Text = "0";  // 현재 화면의 숫자(8)만 0으로 바꿈 [cite: 584]
            isNewInput = true;     // 다음에 숫자를 누르면 0 뒤에 붙지 않고 새로 써지게 함
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // 한 글자 이상 있을 때만 마지막 글자를 제거합니다.
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            }

            // 숫자를 다 지워서 빈 칸이 되거나 "0"만 남으면 기본값 "0"을 표시합니다.
            if (string.IsNullOrEmpty(txtResult.Text) || txtResult.Text == "0")
            {
                txtResult.Text = "0";
                isNewInput = true;
            }
        }
    }
}
    