
using System.Collections.Generic;


namespace GuessTheWord
{
    public interface IView
    {
        void DictionaryMenu();
        void GuessWord();
        void CorrectGuess();
        void IncorrectGuess();
        void PlayerGuess();
    }
}