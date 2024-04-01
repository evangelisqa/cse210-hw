using System;
using System.Collections.Generic;

class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }
    public override bool IsComplete()
    {
        return true; //Eternal goals are never complete
    }
    public override string GetDetailsString()
    {
        return $"Eternal Goal: {Name}";   
    }
    public override string GetStringRepresentation()
    {
        return $"{Name} (Eternal)";
    }
}