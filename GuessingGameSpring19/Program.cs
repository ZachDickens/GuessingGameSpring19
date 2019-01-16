using System;

namespace GuessingGameSpring19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10.");
            string userGuess = Console.ReadLine();
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



            }
        }
    }
}
