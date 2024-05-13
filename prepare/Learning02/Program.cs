using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job
        {
            _company = "Microsoft",
            _jobTitle = "Software Engineer",
            _startYear = 2019,
            _endYear = 2022
        };

        Job job2 = new Job
        {
            _company = "Apple",
            _jobTitle = "Manager",
            _startYear = 2022,
            _endYear = 2023
        };

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Dayo Oluwasuyi";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}