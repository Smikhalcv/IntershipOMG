using System;

namespace LeapYear
{
    class LeapYear
    {
        private string _readYear;
        private int _year;
        private bool? _isLeapYear = null;
        public bool? IsLeapYear
        {
            get { return _isLeapYear; }
        }

        private bool CurrectParseStrToInt()
        {
            _readYear = Console.ReadLine();
            try
            {
                _year = int.Parse(_readYear);
                return true;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не некоректный ввод данных!");
                Console.ResetColor();
                return false;
            }
        }

        private bool ValidateYear()
        {
            if (_year < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не верный ввод данных!");
                Console.ResetColor();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void CheckYear()
        {
            if (CurrectParseStrToInt() && ValidateYear())
            {
                if (_year % 400 == 0)
                {
                    _isLeapYear = true;
                }
                else if (_year % 4 == 0 && _year % 100 != 0)
                {
                    _isLeapYear = true;
                }
                else
                {
                    _isLeapYear = false;
                }
            }            
        }
    }
}
