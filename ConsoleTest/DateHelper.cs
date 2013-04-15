using System;

namespace ConsoleTest
{
    class DateHelper
    {
        public static String CurrentDate() {
            return String.Format("It's {0} on {1}", DateTime.Now.ToString("t"), DateTime.Now.ToString("dd MMM yyyy"));
        }

        /// <summary>
        /// Bugs on purpose
        /// </summary>
        /// <param name="birthdate"></param>
        /// <returns></returns>
        public static String YourAge(DateTime birthdate)
        {
            return String.Format("You are {0} years old", Math.Floor(DateTime.Now.Date.Subtract(birthdate).TotalDays/365));
        }
    }
}
