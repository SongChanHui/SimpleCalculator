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
            // String 데이터를 int로 변환하여 저장
            operand1 = int.Parse(txtResult.Text);
            currentOperator = "+";

            // 상단 수식창에 기록
            txtFormula.Text = operand1.ToString() + " + ";
            isNewInput = true; // 다음 숫자를 받을 준비
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int operand2 = int.Parse(txtResult.Text); // 두 번째 숫자 변환
            int result = 0;

            if (currentOperator == "+")
            {
                result = operand1 + operand2; // 더하기 계산
            }

            // 결과 출력 (숫자를 다시 문자로 변환)
            txtFormula.Text += operand2.ToString() + " = " + result.ToString();
            txtResult.Text = result.ToString();
            isNewInput = true;
        }
    }
}
    