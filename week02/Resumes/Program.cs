using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Google";
        job2._startYear = 2022;
        job2._endYear = 2024;
        Resume resume = new Resume();
        resume._name = "Raene Wayne";
        resume.Jobs.Add(job1);
        resume.Jobs.Add(job2);
        resume.Display();
    }
}