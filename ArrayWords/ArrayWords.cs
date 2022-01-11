using System;
using System.Collections.Generic;

namespace ArrayWords
{
    class ArrayWords
    {
        private char[] _templateVerification;
        private string[] _arrayWordsForCheck;

        public bool? CheckChars(params string[] arrayWords)
        {
            if (ValidateArray(arrayWords))
            {
                _templateVerification = _arrayWordsForCheck[0].ToCharArray();

                for (int i = 1; i < arrayWords.Length; i++)
                {
                    List<char> workingArray = new List<char>(_templateVerification);
                    for (int j = 0; j < _templateVerification.Length; j++)
                    {
                        try
                        {
                            if (workingArray.Contains(arrayWords[i][j]) && workingArray.Count > 0)
                            {
                                workingArray.Remove(arrayWords[i][j]);
                            }
                            else
                            {
                                return false;
                            }
                        }
                        catch (Exception)
                        {
                            return false;
                            throw;
                        }
                        
                    }
                }
                return true;
            }
            else return null;
        }

        private bool ValidateArray(params string[] arrayWords)
        {
            if (arrayWords.Length > 1)
            {
                _arrayWordsForCheck = arrayWords;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не некоректный ввод данных!");
                Console.ResetColor();
                return false;
            }
        }
    }
}
