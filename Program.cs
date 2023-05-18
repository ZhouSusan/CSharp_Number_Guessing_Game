using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            int userGuessNumber = 0;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number' human!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up like a human, purr.");
            do
            {
               Console.WriteLine("Hmmm, that doesn't look like a number. Try again or you can ask woofers over there to help.");
                string theGuess = Console.ReadLine();
                bool result = Int32.TryParse(theGuess, out userGuessNumber);
                Console.WriteLine(theGuess);
                // Keep track of the number of guesses and the current user guess

                // Start the game and run until user quits or guesses correctly
                // HINT: You'll need a way to convert the user's input to an integer
            } while (keepPlaying);
        }
    }
}
