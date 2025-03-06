using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemBankAccount.Base;

namespace SistemBankAccount
{
    class InterestEarningAccount: BankAccount
    {
        public InterestEarningAccount(string owner,decimal initialBalance)
            : base(owner, initialBalance)
        {

        }
    }
    public override void RerformMonthEndTransactions()
    {
        MakeWithdrawal()
    }
}
