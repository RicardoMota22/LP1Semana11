
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;



namespace GuessTheWord
{
    public class UglyView : IView
    {

        public void GuessWord()
        {
            string hint;
            Console.WriteLine("Guess the full word!");
            Console.WriteLine($"Hint: It's a {hint}.");
            Console.WriteLine($"Word: {new string(display)}");
        }

        public void CorrectGuess()
        {
            string chosenWord;
            Console.WriteLine("Correct! Well done!");
            Console.WriteLine($"The word was \"{chosenWord}\".");
        }

        public void IncorrectGuess()
        {
            Console.WriteLine("Incorrect. Try again.");
        }

        public void PlayerGuess()
        {
            string guess;
            Console.Write("Your guess: ");
            guess = Console.ReadLine().Trim().ToLower();
        }
    }
}