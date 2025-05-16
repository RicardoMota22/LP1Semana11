using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheWord
{
    public interface IView
    {
        void DictionaryMenu();
        void GuessWord();
        void CorrectGuess();
        void IncorrectGuess();
    }
}