using System;


namespace SystemOfBankAccount.ValueObjects
{
    struct NumberOfBankAccount
    {
        public long Value { get; set; }
        public NumberOfBankAccount(long number)
        {
            if (number < 1000000000 || number >= 10000000000)
                throw new System.ArgumentOutOfRangeException(
                    nameof(number),
                    "Номер не является валидным");

            Value = number;
        }

    }
}
