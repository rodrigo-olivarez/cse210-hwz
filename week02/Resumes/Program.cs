using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Enginner";
        job1._Company = "Microsoft";
        job1._StartYear = 2019;
        job1._EndYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._Company = "Apple";
        job2._StartYear = 2022;
        job2._EndYear = 2023;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.display();
    }
}