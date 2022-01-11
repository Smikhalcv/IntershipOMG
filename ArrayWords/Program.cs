using System;

namespace ArrayWords
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
                    Console.WriteLine("Все слова состоят из одинаковых символов");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Слова не состоят из одинаковых символов");
                    Console.ResetColor();
                }
            }
        }
        
        static void Main(string[] args)
        {
                        //оставленно для проверки
            string[] example1 = new string[3] { "кот", "ток", "кто" };
            string[] example2 = new string[3] { "кот", "тк", "кТо" };
            string[] example3 = new string[6] { "кот", "тк", "кТо", "кт", "ток", "кто" };
            string[] example4 = new string[3] { "к", "тк", "кТо" };

            bool? result;
            ArrayWords CheckArray = new ArrayWords();
            result = CheckArray.CheckChars(example3);
            Check(result);
            result = CheckArray.CheckChars(example4);
            Check(result);
        }
    }
}
