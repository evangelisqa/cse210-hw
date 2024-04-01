using System;
using System.Collections.Generic;

// Represent a generic goal
abstract class Goal
{
    public string Name { get; set;}
    public int Points { get; set;}
    public int Completed { get; set;}

    public abstract void RecordEvent ();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
}
//
