using System;

namespace ConsoleTest
{
    class DateHelper
    {
        public static String CurrentDate() {
            return String.Format("It's {0} on {1}", DateTime.Now.ToString("t"), DateTime.Now.ToString("dd MMM yyyy"));
        }
    }
}
