
using System;

namespace lesson0
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new(161, 50, DateTime.Parse("12.12.12"), "Mark", "Winston");
            person.ChangeHeight(166);
            ///переопределить метод to string

        }
    }
}

