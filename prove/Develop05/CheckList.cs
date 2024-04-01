using System;
using System.Collections.Generic;

//Represent a checklist goal
class ChecklistGoal : Goal
{
    private int Target { get; set; }
    private int Bomus { get; set; }

    public ChecklistGoal(string name, int points, int target, int bonus)
    {
        Name = name;
        Points = points;
        Target = target;
        Bonus = bonus;
    }
    public override void RecordEvent()
    {
        Completed++;
    }
    public override bool IsComplete()
    {
        return Completed >= Target;
    }
    public override string GetDetailsString()

    {
        return $"Checklist Goal: {Name}({Completed}/{Target} times)";
    }
    public override string GetStringRepresentation()
    {
        return $"{Name}  (Checklist)";
    }
}