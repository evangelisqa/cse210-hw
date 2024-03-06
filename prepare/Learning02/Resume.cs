using System;
public class Resume
{
    public string _name;
    publicList<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.Write($"Name: {_name}");
        Cosole.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}