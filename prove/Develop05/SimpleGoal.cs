using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class SimpleGoal = Goal
{
    public SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }
    public override void RecordEvents()
    {
        Completed++;
    }
    public override bool IsComplete()

    {
        return Comppleted > 0;
    }
    public override string GetDetailsString()
    {
        return $"Simple Goal: {Name}";
    }
    public override string GetStringRepresentation()
    {
        return $"{Name} (Simple)";
    }

}

