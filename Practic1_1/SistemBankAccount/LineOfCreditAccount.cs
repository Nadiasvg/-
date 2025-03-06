using SistemBankAccount.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemBankAccount
{
    class LineOfCreditAccount: BankAccount
    {
        public decimal MinimumBalance
        {
            get; private set;
        }
        public LineOfCreditAccount(string owner, decimal initialBalance)
            : base(owner, initialBalance)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Withdrawal must be positive.");
            }
        }
        public override void PerformMonthEndTransactions()
        {
            if (Balance< 0)
                MakeWithdrawal()
        }
    }
}
