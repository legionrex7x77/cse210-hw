using System;

public class Job
{
    // Member variables use _underscoreCamelCase
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Methods use TitleCase
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}