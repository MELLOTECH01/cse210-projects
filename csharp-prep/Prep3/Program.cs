using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int magicNumberConvert = int.Parse(magicNumber);
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessConvert;
        int noOfGuesses = 0;
        string response;

        do
        {
            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessConvert = int.Parse(guess);
                noOfGuesses++;

                if (guessConvert > magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessConvert < magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (guessConvert != magicNumber);
            Console.WriteLine($"You made {noOfGuesses} guesses!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Do you still want to play again? ");
            response = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
        } while (response == "yes");
    }
}