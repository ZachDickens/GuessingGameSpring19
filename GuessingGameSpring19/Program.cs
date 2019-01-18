using System;

namespace GuessingGameSpring19
{
    class Program
    {
        static void Main(string[] args)
        {
            string userGuess = Console.ReadLine();
            Random rand = new Random();
            int numberOfGuesses = 3;
            int correctAnswer = rand.Next(10);
            
            rand.Next(correctAnswer);
            Console.WriteLine(correctAnswer);
            do
            {
                Console.WriteLine("Please guess a number between 1 and 10, or enter 0 for help.");
                userGuess = Console.ReadLine();

                if (Int32.Parse(userGuess).Equals("0"))
                {
                    Console.WriteLine("=====INSTRUCTIONS=====");
                    Console.WriteLine("Guess a number between 1 and 10.");
                    Console.WriteLine("Hit enter to submit your guess.");

                    userGuess = Console.ReadLine();
                }

                Console.WriteLine("You guessed: " + userGuess);

                // if they guess 7 
                if (Int32.Parse(userGuess).Equals(correctAnswer))
                {
                    // then they win
                    Console.WriteLine("You win!");
                    System.Environment.Exit(1);
                }
                else if (Int32.Parse(userGuess).Equals("-1"))
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    if(correctAnswer > Int32.Parse(userGuess))   
                    {
                      Console.WriteLine("Your guess was too low.");
                    } else
                    {
                        Console.WriteLine("Your guess was too high.");
                    }
                    numberOfGuesses = numberOfGuesses - 1;                    
                    Console.WriteLine("That is incorrect. Please guess again.");
                }
                

            } while (numberOfGuesses > 0);

        }

    }
}
