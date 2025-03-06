using SistemBankAccount.Base;
using System;
using System.Collections.Generic;

namespace SistemBankAccount
{
    class Program
    {
        static void Main(string[] args)

        {
            List<BankAccount> bank = new List<BankAccount>();
            bank.Add(new LineOfCreditAccount("asjsj", 1000));
            bank.Add(new LineOfCreditAccount("asjsj", 1000));
            bank.Add(new LineOfCreditAccount("asjsj", 1000));

            var account1 = new BankAccount("aswdsa", 1000m); // Создание пользователя
            Console.WriteLine($"Account {account1.Number.Value} was created for {account1.Owner} with {account1.Balance} initial balance.");
            var account2 = new BankAccount("aswd", 2000m); // Создание пользователя
            Console.WriteLine($"Account {account2.Number.Value} was created for {account2.Owner} with {account2.Balance} initial balance.");

            account1.MakeDeposit(100m, DateTime.Now, "Степуха"); // 100m - тип decimal, просто 100 - int
            account1.MakeDeposit(20000m, DateTime.Now, "ОТ ДУШИ ОТРыВАЮ");
            account1.MakeWithdrawal(5000m, DateTime.Now, "Покушай");
            Console.WriteLine($"Account {account1.Number.Value} was created for {account1.Owner} with {account1.Balance} initial balance.");
            try
            {
                account1.MakeWithdrawal(2000m, DateTime.Now, "Долг");
            }
            catch (ArgumentOutOfRangeException E)
            {
                Console.WriteLine(E.Message, E.ParamName);
            }
            catch (InvalidOperationException E)
            {
                Console.WriteLine(E.Message, E.ToString());
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message, E.ToString());
            }
        }
    }
}
