using System;

namespace BracketSequence
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
                    Console.WriteLine("Правильная скобочкая последовательность!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Не правильная скобочкая последовательность.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Содержит посторонние символы!");
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            var BracketSequence = new BracketSequence();
            Console.WriteLine("Введите скобочную последовательность -");
            string typedStr = Console.ReadLine();
            Check(BracketSequence.CheckSequence(typedStr));
        }
    }
}
