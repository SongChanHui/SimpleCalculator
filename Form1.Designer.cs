namespace SimpleCalculator
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeader = new Label();
            txtFormula = new TextBox();
            txtResult = new TextBox();
            btnCE = new Button();
            btnC = new Button();
            btnDel = new Button();
            btnDiv = new Button();
            btnMulti = new Button();
            btnNum9 = new Button();
            btnNum8 = new Button();
            btnNum7 = new Button();
            btnMinus = new Button();
            btnNum6 = new Button();
            btnNum5 = new Button();
            btnNum4 = new Button();
            btnPlus = new Button();
            btnNum3 = new Button();
            btnNum2 = new Button();
            btnNum1 = new Button();
            btnEqual = new Button();
            btnDot = new Button();
            button18 = new Button();
            btnSign = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = SystemColors.MenuHighlight;
            lblHeader.Location = new Point(4, 19);
            lblHeader.Margin = new Padding(8, 0, 8, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(852, 128);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Simple Calculator";
            lblHeader.Click += label1_Click;
            // 
            // txtFormula
            // 
            txtFormula.BackColor = SystemColors.ButtonHighlight;
            txtFormula.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFormula.Location = new Point(89, 211);
            txtFormula.Name = "txtFormula";
            txtFormula.ReadOnly = true;
            txtFormula.Size = new Size(682, 93);
            txtFormula.TabIndex = 1;
            txtFormula.TextAlign = HorizontalAlignment.Right;
            txtFormula.TextChanged += txtFormula_TextChanged;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.ActiveCaption;
            txtResult.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(86, 331);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(685, 93);
            txtResult.TabIndex = 2;
            txtResult.TextAlign = HorizontalAlignment.Right;
            txtResult.TextChanged += txtFormula_TextChanged;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(89, 447);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(139, 101);
            btnCE.TabIndex = 3;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(272, 447);
            btnC.Name = "btnC";
            btnC.Size = new Size(139, 101);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(453, 447);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(139, 101);
            btnDel.TabIndex = 5;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.ForeColor = Color.Red;
            btnDiv.Location = new Point(634, 447);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(139, 101);
            btnDiv.TabIndex = 6;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            btnMulti.ForeColor = Color.Red;
            btnMulti.Location = new Point(634, 573);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(139, 101);
            btnMulti.TabIndex = 10;
            btnMulti.Text = "x";
            btnMulti.UseVisualStyleBackColor = true;
            // 
            // btnNum9
            // 
            btnNum9.ForeColor = Color.Blue;
            btnNum9.Location = new Point(453, 573);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(139, 101);
            btnNum9.TabIndex = 9;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = true;
            btnNum9.Click += btnNum_Click;
            // 
            // btnNum8
            // 
            btnNum8.ForeColor = Color.Blue;
            btnNum8.Location = new Point(272, 573);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(139, 101);
            btnNum8.TabIndex = 8;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = true;
            btnNum8.Click += btnNum_Click;
            // 
            // btnNum7
            // 
            btnNum7.ForeColor = Color.Blue;
            btnNum7.Location = new Point(91, 573);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(139, 101);
            btnNum7.TabIndex = 7;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = true;
            btnNum7.Click += btnNum_Click;
            // 
            // btnMinus
            // 
            btnMinus.ForeColor = Color.Red;
            btnMinus.Location = new Point(634, 699);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(139, 101);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnNum6
            // 
            btnNum6.ForeColor = Color.Blue;
            btnNum6.Location = new Point(453, 699);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(139, 101);
            btnNum6.TabIndex = 13;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = true;
            btnNum6.Click += btnNum_Click;
            // 
            // btnNum5
            // 
            btnNum5.ForeColor = Color.Blue;
            btnNum5.Location = new Point(272, 699);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(139, 101);
            btnNum5.TabIndex = 12;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = true;
            btnNum5.Click += btnNum_Click;
            // 
            // btnNum4
            // 
            btnNum4.ForeColor = Color.Blue;
            btnNum4.Location = new Point(89, 699);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(139, 101);
            btnNum4.TabIndex = 11;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = true;
            btnNum4.Click += btnNum_Click;
            // 
            // btnPlus
            // 
            btnPlus.ForeColor = Color.Red;
            btnPlus.Location = new Point(634, 825);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(139, 101);
            btnPlus.TabIndex = 18;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnNum3
            // 
            btnNum3.ForeColor = Color.Blue;
            btnNum3.Location = new Point(453, 825);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(139, 101);
            btnNum3.TabIndex = 17;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += btnNum_Click;
            // 
            // btnNum2
            // 
            btnNum2.ForeColor = Color.Blue;
            btnNum2.Location = new Point(272, 825);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(139, 101);
            btnNum2.TabIndex = 16;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += btnNum_Click;
            // 
            // btnNum1
            // 
            btnNum1.ForeColor = Color.Blue;
            btnNum1.Location = new Point(89, 825);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(139, 101);
            btnNum1.TabIndex = 15;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += btnNum_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(634, 951);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(139, 101);
            btnEqual.TabIndex = 22;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(453, 951);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(139, 101);
            btnDot.TabIndex = 21;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.ForeColor = Color.Blue;
            button18.Location = new Point(272, 951);
            button18.Name = "button18";
            button18.Size = new Size(139, 101);
            button18.TabIndex = 20;
            button18.Text = "0";
            button18.UseVisualStyleBackColor = true;
            button18.Click += btnNum_Click;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(91, 951);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(139, 101);
            btnSign.TabIndex = 19;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(35F, 78F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 1086);
            Controls.Add(btnEqual);
            Controls.Add(btnDot);
            Controls.Add(button18);
            Controls.Add(btnSign);
            Controls.Add(btnPlus);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(btnMinus);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnMulti);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnDiv);
            Controls.Add(btnDel);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(txtResult);
            Controls.Add(txtFormula);
            Controls.Add(lblHeader);
            Font = new Font("맑은 고딕", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(8);
            Name = "FormMain";
            Text = "Calculator v1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private TextBox txtFormula;
        private TextBox txtResult;
        private Button btnCE;
        private Button btnC;
        private Button btnDel;
        private Button btnDiv;
        private Button btnMulti;
        private Button btnNum9;
        private Button btnNum8;
        private Button btnNum7;
        private Button btnMinus;
        private Button btnNum6;
        private Button btnNum5;
        private Button btnNum4;
        private Button btnPlus;
        private Button btnNum3;
        private Button btnNum2;
        private Button btnNum1;
        private Button btnEqual;
        private Button btnDot;
        private Button button18;
        private Button btnSign;
    }
}
