using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables use _underscoreCamelCase
    public string _personName;
    public List<Job> _jobs = new List<Job>();

    // Methods use TitleCase
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        
        // Loop through each job in the list and call its Display method
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}