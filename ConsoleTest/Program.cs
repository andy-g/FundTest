using System;

//This is a simple Console Application to test Git
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine(String.Format("{0}: Boom, Boom, Boom!", DateHelper.CurrentDate()));
            Console.WriteLine("Enter your birth date");
            var date = Console.ReadLine();
            Console.WriteLine(DateHelper.YourAge(Convert.ToDateTime(date)));
            Console.WriteLine(DateHelper.DaysToBirthday(Convert.ToDateTime(date)));
            Console.WriteLine("Hit a key to continue...");
            Console.ReadKey();
        }
    }
}
