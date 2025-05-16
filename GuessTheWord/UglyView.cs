using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GuessTheWord
{
    public class UglyView : IView
    {
        public string DictionaryMenu()
        {
            { "apple", "fruit" },
            { "banana", "fruit" },
            { "tiger", "animal" },
            { "elephant", "animal" },
            { "guitar", "instrument" },
            { "violin", "instrument" },
            { "canada", "country" },
            { "brazil", "country" },
            { "laptop", "object" },
            { "microscope", "scientific instrument" }
        }
        public void GuessWord()
        {
            Console.WriteLine("Guess the full word!");
            Console.WriteLine($"Hint: It's a {hint}.");
            Console.WriteLine($"Word: {new string(display)}");
        }

        public void CorrectGuess()
        {
            Console.WriteLine("Correct! Well done!");
            Console.WriteLine($"The word was \"{chosenWord}\".");
        }

        public void IncorrectGuess()
        {
            Console.WriteLine("Incorrect. Try again.");
        }
    }
}