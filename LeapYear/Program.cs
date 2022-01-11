using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            var checkYear = new LeapYear();

            Console.WriteLine("Укажите год: ");
            checkYear.CheckYear();
            bool? result = checkYear.IsLeapYear;
            if (result != null)
            {
                if (result == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Год високосный!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Год не високосный!");
                    Console.ResetColor();
                }
            }
        }
    }
}
