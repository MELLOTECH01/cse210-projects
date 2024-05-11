using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string userName = PromptUserName();
        int userFavouriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userFavouriteNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        int favouriteNumber = int.Parse(Console.ReadLine());
        return favouriteNumber;
    }

    static int SquareNumber(int favouriteNumber)
    {
        int squaredNumber = favouriteNumber * favouriteNumber;
        return squaredNumber;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your favourite number is {squaredNumber}");
    }
}