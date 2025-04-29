using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingsAccount(string owner, decimal interestRate) : base(owner + " ("+ interestRate + "%)")
        {
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You cannot deposit $" + amount;

            if (amount > 20000)
                return "AML Deposit Limit Reached!";

            decimal interestAmount = (InterestRate / 100) * amount;

            Balance += amount + interestAmount;
            return "Deposit completed succesfully";

        }

    }
}
