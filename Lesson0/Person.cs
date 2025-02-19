using lesson0.Validators;
using System;

namespace lesson0
{
    /// <summary>
    /// Person information
    /// </summary>
    class Person
    {
        public Person(
            int Height,
            int Weight,
            DateTime Birthday,
            string FirstName,
            string LastName)
        {
            if (IntValidator.Validate(Height))
                throw new ArgumentOutOfRangeException("Исключение");
            if (IntValidator.Validate(Weight))
                throw new ArgumentOutOfRangeException("Исключение");
            if (StringValidator.Validate(FirstName))
                throw new ArgumentException("Исключение");
            if (StringValidator.Validate(LastName))
                throw new ArgumentException("Исключение");

            Height = Height;
            Weight = Weight;
            FirstName = FirstName;
            LastName = LastName;

        }

        /// <summary>
        /// getting and changing Height
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// getting and changing weight
        /// </summary>
        public int Weight { get; private set; }

        /// <summary>
        /// getting and changing FirstName
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// getting and changing LastName
        /// </summary>
        public string LastName { get; private set; }

        /// <summary>
        /// adding date of birth
        /// </summary>
        public DateTime BirthDay { get; }

        /// <summary>
        /// getting a full name
        /// </summary>
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public int Age
        {
            get
            {
                return (DateTime.Now - BirthDay).Days / 365;
            }
        }

        public bool ChangeHeight(int Height)
        {
            bool flag = IntValidator.Validate(Height);
            if (flag)
                this.Height = Height;
            return flag;
        }

    }
}
