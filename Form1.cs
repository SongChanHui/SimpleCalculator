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
            // 1. 이미 연산자가 있고, 숫자가 입력된 상태라면 중간 계산을 먼저 수행합니다.
            if (currentOperator != "" && isNewInput == false)
            {
                int operand2 = int.Parse(txtResult.Text); // 현재 화면의 숫자(34)를 가져옵니다[cite: 221, 225].

                if (currentOperator == "+")
                {
                    operand1 += operand2; // 기존 12에 34를 더해 46으로 만듭니다.
                }
                // 과제 2를 위해 -, *, / 등도 같은 방식으로 여기에 추가하면 됩니다[cite: 367, 555].

                txtResult.Text = operand1.ToString(); // 결과인 46을 화면에 보여줍니다[cite: 244, 247].
            }
            else
            {
                // 2. 처음 연산자를 누른 경우 (예: 12 입력 후 + 클릭)
                operand1 = int.Parse(txtResult.Text);
            }

            currentOperator = "+";
            txtFormula.Text = operand1.ToString() + " + "; // 수식창에 "46 + "으로 업데이트합니다.
            isNewInput = true; // 다음 숫자 입력을 위해 상태를 바꿉니다.
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (currentOperator == "") return;

            int operand2 = int.Parse(txtResult.Text);
            int result = 0;

            if (currentOperator == "+")
            {
                result = operand1 + operand2;
            }

            // 수식창에 전체 과정(12 + 34 = 46)을 표시합니다[cite: 257, 485].
            txtFormula.Text = operand1.ToString() + " " + currentOperator + " " + operand2.ToString() + " = " + result.ToString();
            txtResult.Text = result.ToString();

            operand1 = result; // 계산된 결과를 다음 연산의 시작값으로 저장합니다.
            currentOperator = ""; // 연산자 초기화
            isNewInput = true;
        }
    }
}
    