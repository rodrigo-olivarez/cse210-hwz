using System;

public class Job
{
    public string _jobTitle = "";
    public string _Company = "";
    public int _StartYear = 0;
    public int _EndYear = 0;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_Company}) {_StartYear}-{_EndYear}");
    }

}