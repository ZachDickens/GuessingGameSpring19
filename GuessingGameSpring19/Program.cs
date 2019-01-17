using System;

namespace GuessingGameSpring19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10, or enter 0 for help.");
            
            string userGuess = Console.ReadLine();

            int numberOfGuesses = 3;

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
                System.Environment.Exit(1);
            }
            else if (userGuess.Equals("-1"))
            {
                System.Environment.Exit(1);
            }
            else
            {
                numberOfGuesses = numberOfGuesses - 1;
                userGuess = Console.ReadLine();
                Console.Write("I am sorry.");
                Console.WriteLine("That is incorrect. Please guess again.");
            
            }
            Console.WriteLine("Please guess a number between 1 and 10, or enter 0 for help.");
            userGuess = Console.ReadLine();


        }

    }
}
