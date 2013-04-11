using System;

//This is a simple Console Application to test Git
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine(String.Format("{0}: Boom, Boom, Boom!", DateHelper.CurrentDate()));
            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();
        }
    }
}
