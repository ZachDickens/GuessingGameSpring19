using System;

namespace GuessingGameSpring19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10, or enter 0 for help.");
            
            string userGuess = Console.ReadLine();

            if (userGuess.Equals("0"))
            {
                Console.WriteLine("=====INSTRUCTIONS=====");
                Console.WriteLine("Guess a number between 1 and 10.");
                Console.WriteLine("Hit enter to submit your guess.");

                userGuess = Console.ReadLine();
            }

            Console.WriteLine("You guessed: " + userGuess);

            // if they guess 7 
            if (userGuess.Equals("7"))
            {
                // then they win
                Console.WriteLine("You win!");
            }
            else
            {
                // otherwise they lose
                Console.WriteLine("You lost.");
                // user guesses 0 
                
                               

            }
        }
    }
}
