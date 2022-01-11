using System;

namespace Polindrome
{
    class Program
    {
        private static void Check(bool? result)
        {
            if (result != null)
            {
                if (result == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Строка полиндром!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Строка не полиндром.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Строка пустая.");
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            var polindrome = new Polindrome();
            string _checkingString;
            Console.WriteLine("Введите строку -");
            _checkingString = Console.ReadLine();
            Check(polindrome.CheckString(_checkingString));
        }
    }
}
