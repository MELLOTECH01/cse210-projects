using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int numberConvert;
        List<int> numbers = new List<int>();
        double difference;
        double  smallest = 1000000;

        do
        {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();
        numberConvert = int.Parse(number);
        numbers.Add(numberConvert); 
        } while (numberConvert != 0);

        numbers.Remove(0);
        foreach (double item in numbers)
        {
            difference = item - 0;
            if (difference < smallest && item > 0)
            {
                smallest = difference;
            }
        }
        double sum = numbers.Sum();
        double avg = numbers.Average();
        double largest = numbers.Max();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        numbers.Sort();
        foreach (double item in numbers)
        {
            Console.WriteLine(item);
        }

    }
}