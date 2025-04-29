namespace BankAccountApp
{
    public partial class App : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();

        public App()
        {
            InitializeComponent();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;

            if (InterestNum.Value > 0)
            {
                SavingsAccount savingsAccount = new SavingsAccount(OwnerTxt.Text, InterestNum.Value);
                BankAccounts.Add(savingsAccount);
            }
            else
            {
                BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
                BankAccounts.Add(bankAccount);
            }

            RefreshGrid();
            OwnerTxt.Text = string.Empty;
            InterestNum.Value = 0;
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Deposit(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = selectedBankAccount.Withdraw(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }

    }
}
