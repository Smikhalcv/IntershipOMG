using System;
using System.Collections.Generic;
using System.Text;

namespace Polindrome
{
    class Polindrome
    {
        private int _startIndChar = 0;
        private int _endIndChar;
        private List<char> _excludedChars = new List<char> { ' ', ',', '.', '!', '?', ';', ':', '/', '|', '\\'};

        public bool? CheckString(string stringForChecking)
        {
            if (stringForChecking.Length == 0)
            {
                return null;
            }
            stringForChecking = stringForChecking.ToLower();
            _endIndChar = stringForChecking.Length - 1;
            while (_startIndChar != _endIndChar)
            {
                if (stringForChecking[_startIndChar] == stringForChecking[_endIndChar])
                {
                    _startIndChar++;
                    _endIndChar--;
                }
                else if (_excludedChars.Contains(stringForChecking[_startIndChar]))
                {
                    _startIndChar++;
                }
                else if (_excludedChars.Contains(stringForChecking[_endIndChar]))
                {
                    _endIndChar--;
                }
                else return false;
            }
            return true;
        }
    }
}
