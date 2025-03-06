using SistemBankAccount.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemBankAccount.Base
{
    class BankAccount
    {
        private List<Transaction> _allTransaction = new List<Transaction>();
        private static int s_accountNumberSeed = 1000000000;
        


        public NumberOfBankAccount Number { get; }
        public string Owner { get; private set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransaction)
                    balance += item.Amount;
                return balance;
            }
        }
        public BankAccount(string fullName, Decimal initialBalance)
        {
            Number = new NumberOfBankAccount(s_accountNumberSeed++);
            Owner = fullName;
            MakeDeposit(initialBalance, DateTime.Now, "initial balance");
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive.");
            }

            var deposit = new Transaction(amount, date, note);
            _allTransaction.Add(deposit);

        }
        public virtual void MakeWithdrawal(decimal amount, DateTime date, string note) // Списание
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Withdrawal must be positive.");
            }

            if (Balance - amount <= 0)
            {
                throw new InvalidOperationException("Not sufficient rubls for this withdrawal.");
            }


            _allTransaction.Add(new Transaction(-amount, date, note));
        }
        public abstract override void PerformMonthEndTransactions()
        {

        }
        public string HistoryOfTransactoins()
        {
            StringBuilder str = new();

            foreach (var elem in _allTransaction)
                str.AppendLine(elem.Totring());
            return str.ToString();
        }

    }
}
