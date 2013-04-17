using System;

namespace ConsoleTest
{
    class DateHelper
    {
        public static String CurrentDate() {
            return String.Format("It's {0} on {1}", DateTime.Now.ToString("t"), DateTime.Now.ToString("dd MMM yyyy"));
        }

        /// <summary>
        /// Calculate the users age
        /// </summary>
        /// <param name="birthdate"></param>
        /// <returns></returns>
        public static String YourAge(DateTime birthdate)
        {
            int age = DateTime.Today.Year - birthdate.Year;
            if (birthdate > DateTime.Today.AddYears(-age)) age--;
            return String.Format("You are {0} years old", age);
        }

        /// <summary>
        /// Calculate the number of days until the users birthday
        /// </summary>
        public static String DaysToBirthday(DateTime birthdate) {
            int daysToBirthday = (int)new DateTime(DateTime.Now.Year, birthdate.Month, birthdate.Day).Subtract(DateTime.Now.Date).TotalDays;
            if (daysToBirthday < 0)
                daysToBirthday = (int)new DateTime(DateTime.Now.Year + 1, birthdate.Month, birthdate.Day).Subtract(DateTime.Now.Date).TotalDays;

            if (daysToBirthday == 0)
                return "Happy birthday";
            if (daysToBirthday == 1)
                return String.Format("There is 1 day until your birthday");
            return String.Format("There are {0} days until your birthday", daysToBirthday);
        }

        public static String OutputStarSign(DateTime birthdate)
        {
            return String.Format("Your star sign is {0}.", StarSign(birthdate));
        }

        private static String StarSign(DateTime birthdate)
        {
            switch (birthdate.Month)
            {
                case 11:
                    return birthdate.Day >= 1 && birthdate.Day <= 21 ? "Scorpio" : "Sagittarius";
                case 12:
                    return birthdate.Day >= 1 && birthdate.Day <= 21 ? "Sagittarius" : "Capricorn";
                default:
                    return "OF UNKNOWN COSMIC ORIGIN. YOU ARE AN ALIEN";
            }
        }
    }
}
