using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        // Creating a Math assignment
		MathAssignment mathAssignment = new MathAssignment("Dayo Oluwasuyi", "Fractions", "7.3", "3-10, 20-21");
		Console.WriteLine(mathAssignment.GetSummary());
		Console.WriteLine(mathAssignment.GetHomeworkList());

		// Creating a Writing assignment
		WritingAssignment writingAssignment = new WritingAssignment("Olaitan Omoniyi", "European History", "The Causes of World War II");
		Console.WriteLine(writingAssignment.GetSummary());
		Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}