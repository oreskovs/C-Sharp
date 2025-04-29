namespace BankAccountApp
{
    partial class App
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
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            Withdraw = new Button();
            DepositBtn = new Button();
            CreateAccountBtn = new Button();
            label3 = new Label();
            label1 = new Label();
            InterestNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestNum).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 425);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 30);
            label2.TabIndex = 1;
            label2.Text = "Amount: ";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(209, 48);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(188, 36);
            OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(139, 419);
            AmountNum.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(188, 36);
            AmountNum.TabIndex = 10;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(447, 45);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.Size = new Size(506, 326);
            BankAccountsGrid.TabIndex = 4;
            // 
            // Withdraw
            // 
            Withdraw.Location = new Point(724, 406);
            Withdraw.Name = "Withdraw";
            Withdraw.Size = new Size(229, 49);
            Withdraw.TabIndex = 5;
            Withdraw.Text = "Withdraw";
            Withdraw.UseVisualStyleBackColor = true;
            Withdraw.Click += Withdraw_Click;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(447, 406);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(235, 49);
            DepositBtn.TabIndex = 6;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(209, 160);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(188, 44);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 48);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 9;
            label3.Text = "Owner:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 102);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 11;
            label1.Text = "Interest Rate (%)";
            // 
            // InterestNum
            // 
            InterestNum.Location = new Point(209, 102);
            InterestNum.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            InterestNum.Name = "InterestNum";
            InterestNum.Size = new Size(188, 36);
            InterestNum.TabIndex = 12;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 517);
            Controls.Add(InterestNum);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(CreateAccountBtn);
            Controls.Add(DepositBtn);
            Controls.Add(Withdraw);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "App";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button Withdraw;
        private Button DepositBtn;
        private Button CreateAccountBtn;
        private Label label3;
        private Label label1;
        private NumericUpDown InterestNum;
    }
}
