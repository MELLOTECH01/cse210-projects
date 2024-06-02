using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        while (true)
		{
			Console.WriteLine("Menu Options:");
			Console.WriteLine("1. Start breathing Activity");
			Console.WriteLine("2. Start reflecting Activity");
			Console.WriteLine("3. Start listing Activity");
			Console.WriteLine("4. Quit");
			Console.Write("Select a choice from the menu: ");
			int choice = int.Parse(Console.ReadLine());

			switch (choice)
			{
				case 1:
					BreathingActivity breathingActivity = new BreathingActivity();
					breathingActivity.Run();
					break;
				case 2:
					ReflectingActivity reflectingActivity = new ReflectingActivity();
					reflectingActivity.Run();
					break;
				case 3:
					ListingActivity listingActivity = new ListingActivity();
					listingActivity.Run();
					break;
				case 4:
					return;
				default:
					Console.WriteLine("Invalid choice. Please try again.");
					break;
			}
		}
    }
}

class Activity
{
	protected string _name;
	protected string _description;
	protected int _duration;

	public Activity(string name, string description)
	{
		_name = name;
		_description = description;
	}

	public void DisplayStartingMessage()
	{
		Console.WriteLine($"Starting {_name} Activity");
		Console.WriteLine(_description);
		Console.Write("Enter the duration (in seconds): ");
		_duration = int.Parse(Console.ReadLine());
		Console.WriteLine("Prepare to begin...");
		ShowSpinner(5);
	}

	public void DisplayEndingMessage()
	{
		Console.WriteLine($"Good job! You have completed the {_name} Activity for {_duration} seconds.");
		ShowSpinner(5);
	}

	public void ShowSpinner(int seconds)
	{
		for (int i = 0; i < seconds; i++)
		{
			Console.Write("|");
			Thread.Sleep(250);
			Console.Write("\b/");
			Thread.Sleep(250);
			Console.Write("\b-");
			Thread.Sleep(250);
			Console.Write("\b\\");
			Thread.Sleep(250);
			Console.Write("\b");
		}
		Console.WriteLine();
	}

	public void ShowCountDown(int seconds)
	{
		for (int i = seconds; i > 0; i--)
		{
			Console.Write(i + " ");
			Thread.Sleep(1000);
		}
		Console.WriteLine();
	}
}

class BreathingActivity : Activity
{
	public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
	{
	}

	public void Run()
	{
		DisplayStartingMessage();
		int cycles = _duration / 10; // Assuming 5 seconds for inhale and 5 seconds for exhale
		for (int i = 0; i < cycles; i++)
		{
			Console.WriteLine("Breathe in...");
			ShowCountDown(5);
			Console.WriteLine("Breathe out...");
			ShowCountDown(5);
		}
		DisplayEndingMessage();
	}
}

class ReflectingActivity : Activity
{
	private List<string> _prompts;
	private List<string> _questions;

	public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
	{
		_prompts = new List<string>
		{
			"Think of a time when you stood up for someone else.",
			"Think of a time when you did something really difficult.",
			"Think of a time when you helped someone in need.",
			"Think of a time when you did something truly selfless."
		};

		_questions = new List<string>
		{
			"Why was this experience meaningful to you?",
			"Have you ever done anything like this before?",
			"How did you get started?",
			"How did you feel when it was complete?",
			"What made this time different than other times when you were not as successful?",
			"What is your favorite thing about this experience?",
			"What could you learn from this experience that applies to other situations?",
			"What did you learn about yourself through this experience?",
			"How can you keep this experience in mind in the future?"
		};
	}

	private string GetRandomPrompt()
	{
		Random rand = new Random();
		int index = rand.Next(_prompts.Count);
		return _prompts[index];
		// Console.WriteLine(" ");
		// Console.WriteLine("When you have something in mind, press enter to continue");
		// Console.ReadLine();
	}

	private string GetRandomQuestion()
	{
		Random rand = new Random();
		int index = rand.Next(_questions.Count);
		return _questions[index];
	}

	public void Run()
	{
		DisplayStartingMessage();
		Console.WriteLine(GetRandomPrompt());
		ShowSpinner(5);
		int questionTime = _duration / _questions.Count;
		foreach (var question in _questions)
		{
			Console.WriteLine(question);
			ShowSpinner(questionTime);
		}
		DisplayEndingMessage();
	}
}

class ListingActivity : Activity
{
	private List<string> _prompts;
	private int _count;

	public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
	{
		_prompts = new List<string>
		{
			"Who are people that you appreciate?",
			"What are personal strengths of yours?",
			"Who are people that you have helped this week?",
			"When have you felt the Holy Ghost this month?",
			"Who are some of your personal heroes?"
		};
	}

	private string GetRandomPrompt()
	{
		Random rand = new Random();
		int index = rand.Next(_prompts.Count);
		return _prompts[index];
	}

	private List<string> GetListFromUser()
	{
		List<string> items = new List<string>();
		DateTime endTime = DateTime.Now.AddSeconds(_duration);
		Console.WriteLine("Start listing items...");
		while (DateTime.Now < endTime)
		{
			Console.Write("> ");
			string item = Console.ReadLine();
			if (!string.IsNullOrEmpty(item))
			{
				items.Add(item);
			}
		}
		return items;
	}

	public void Run()
	{
		DisplayStartingMessage();
		Console.WriteLine(GetRandomPrompt());
		ShowCountDown(5);
		List<string> items = GetListFromUser();
		Console.WriteLine($"You listed {items.Count} items.");
		DisplayEndingMessage();
	}
}
