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

            if (bracketSequence.Count % 2 != 0)
            {
                return false;
            }
            _limitCheck = (int)bracketSequence.Count / 2;

            while (bracketSequence.Count != 0)
            {
                //Check that all chars are bracket
                if (!_dictBracket.ContainsKey(bracketSequence[_checkingPosition]))
                {
                    return null;
                }

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


        /*
         * Здравствуй, проверяющий(ая)!
        Меня зовут Александр, как говорят, свитчер.
        Моя нинешняя работа ниразу не связана с IT, поэтому многие моменты мне не понятны.
        Сейчас я прохожу обучение в  онлайн университете Skillbox по курсу Unity разработчик.
        Всё это время я работал один, старался свои домашние задания сделать в полноценные игры,
        которые можно показать родными, друзьям, коллегам. Поэтому у меня немного хромает командная работа 
        с git, commit'ов в целом мало IDE и так сохраняет прогресс написания, а pull request я делал только
        однажды, но эти знания я подтяну. Все свои задания я делал на 110% и это не вызывало у меня каких-то
        сомнений или ощущения что я сделал что-то не так. В частности проверка на ввод пользователем.
        Но вот в процессе выполнение тестового задания
        в вашу компанию я впервые над этим задумался. Ведь компания это ни один и ни два человека. 
        Является ли это "плохим тоном" или необходимо строго соблюдать условия задания? 
        Так же мне не совсем нравиться архитектура выполненного мной задания, но я не могу придумать как
        его улучшить и сделать менее связаным. Хочу попросить тебя по возможности дать фидбэк, каким
        паттернам/алгоритмам следует уделить внимание, чтоб улучшить мою манеру написания кода
        или может какие-то советы или рекомендации.
        Со мной можно связаться в телеграмме @Smikhalcv, LinkedIn - linkedin.com/in/aleksandr-mikhaltcov-b74b801ab
        или по телефону +37529-168-05-40.
        Спасибо за внимание и работу!
        С уважением, Александр!
         */
    }
}
