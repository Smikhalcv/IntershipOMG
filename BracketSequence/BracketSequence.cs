using System;
using System.Collections.Generic;
using System.Text;

namespace BracketSequence
{
    class BracketSequence
    {
        private List<char> _arrayOpenBracket = new List<char> {'(', '[', '{'};
        private List<char> _arrayCloseBracket = new List<char> { ')', ']', '}' };
        private Dictionary<char, int> _dictBracket = new Dictionary<char, int>() 
            { 
                { '(', 0 }, 
                { ')', 0 },
                { '[', 0 },
                { ']', 0 },
                { '{', 0 },
                { '}', 0 }
            };
        private int _limitCheck;
        private int _checkingPosition = 0;
        private int _indCheckingCharInBracketList;

        public bool? CheckSequence(string strBracketSequence)
        {
            List<char> bracketSequence = new List<char>(strBracketSequence);

            if (!_dictBracket.ContainsKey(bracketSequence[_checkingPosition]))
            {
                return null;
            }

            if (bracketSequence.Count % 2 != 0)
            {
                return false;
            }
            _limitCheck = (int)bracketSequence.Count / 2;

            while (bracketSequence.Count != 0)
            {
                if (_checkingPosition >= _limitCheck)
                {
                    return false;
                }
                
                _dictBracket[bracketSequence[_checkingPosition]] += 1;
                if (!CheckDictionary())
                {
                    return false;
                }
                
                if (_arrayOpenBracket.Contains(bracketSequence[_checkingPosition]))
                {
                    _indCheckingCharInBracketList = _arrayOpenBracket.IndexOf(bracketSequence[_checkingPosition]);
                    if (bracketSequence[_checkingPosition + 1] == _arrayCloseBracket[_indCheckingCharInBracketList])
                    {
                        bracketSequence.RemoveAt(_checkingPosition);
                        bracketSequence.RemoveAt(_checkingPosition);
                        _limitCheck = bracketSequence.Count;
                        _checkingPosition--;
                        if (_checkingPosition < 0)
                        {
                            _checkingPosition = 0;
                        }
                    }
                    else
                    {
                        _checkingPosition++;
                    }
                }
                               
            }
            return true;
        }

        private bool CheckDictionary()
        {
            if (_dictBracket[')'] > _dictBracket['('] || _dictBracket[']'] > _dictBracket['['] || _dictBracket['}'] > _dictBracket['{'])
            {
                return false;
            }
            else return true;
        }

    }
}
