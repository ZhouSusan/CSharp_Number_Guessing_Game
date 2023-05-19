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
            int guessCounts = 0;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number' human!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up like a human, purr.");
            do
            {
                Console.WriteLine("What's your guess?");
                string theGuess = Console.ReadLine();
                bool result = Int32.TryParse(theGuess, out userGuessNumber);

                if (!result)
                {
                    Console.WriteLine("Hmmm, that doesn't look like a number. Try again or you can ask woofers over there to help.");
                }
                else
                {
                    guessCounts++;
                    if (userGuessNumber == -1)
                    {
                        keepPlaying = false;
                        Console.WriteLine($"Hmm...Looks like the number was {theNumber}. Better luck next time!");
                    }
                    else if (userGuessNumber < theNumber)
                    {
                        Console.WriteLine("Purrr, too low human~ Try again =^.^=");
                    }
                    else if (userGuessNumber > theNumber)
                    {
                        Console.WriteLine("Purrr, too high human~ Try again =^.^=");
                    } else
                    {
                        Console.WriteLine($"You got it in {guessCounts} guesses!!");
                        keepPlaying = false;
                    }

                }
            } while (keepPlaying);
            string mouseCost = guessCounts == 1 ? "1 mouse!" : $"{guessCounts} mice!";
            Console.WriteLine($"Thank you for playing, that will be {mouseCost}");
        }
    }
}
