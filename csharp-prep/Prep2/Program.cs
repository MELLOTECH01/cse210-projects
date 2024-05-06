using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("");
        Console.Write("What is your grage percentage in CSE210? ");
        string gradePercentage = Console.ReadLine();
        int gradePercentageConvert = int.Parse(gradePercentage);
        string letter;
        int remainder = gradePercentageConvert % 10;
        string sign;

        if (gradePercentageConvert >= 90)
        {
            letter = "A";
        }
        else if (gradePercentageConvert >= 80)
        {
            letter = "B";
        }
        else if (gradePercentageConvert >= 70)
        {
            letter = "C";
        }
        else if (gradePercentageConvert >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (remainder >= 7 && !(letter == "A" || letter == "F"))
        {
            sign = "+";
        }
        else if (remainder < 3 && letter != "F")
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is {letter}{sign}");
        if (gradePercentageConvert >= 70)
        {
            Console.Write("Congratulations! You passed!");
        }
        else
        {
            Console.Write("We are sorry! We enconrage you to try again and do better.");
        }
    }
}