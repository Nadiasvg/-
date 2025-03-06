using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemBankAccount.ValueObjects
{
    struct NumberOfBankAccount
    {

        public int Value
        {
            get;
            set;
        }
        public NumberOfBankAccount(int number)
        {
            if (number < 1000000000 || number <= 10000000000)
                throw new System.ArgumentOutOfRangeException(nameof(number), "the number must contain only 10 digits");
            Value = number;
        }

    }
}
