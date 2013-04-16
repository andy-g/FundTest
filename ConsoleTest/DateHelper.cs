using System;

namespace ConsoleTest
{
    class DateHelper
    {
        public static String CurrentDate() {
            return String.Format("It's {0} on {1}", DateTime.Now.ToString("t"), DateTime.Now.ToString("dd MMM yyyy"));
        }

        /// <summary>
        /// </summary>
        /// <param name="birthdate"></param>
        /// <returns></returns>
        public static String YourAge(DateTime birthdate)
        {
            int age = DateTime.Today.Year - birthdate.Year;
            if (birthdate > DateTime.Today.AddYears(-age)) age--;
            return String.Format("You are {0} years old", age);
        }
    }
}
