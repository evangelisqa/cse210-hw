using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var goalManager = new GoalManager();
        goalManager.Start();
        goalManager.CreateGoals();
        goalManager.RecordEvent();

        goalManager.ListGoalsName().ForEach(Console.WriteLine);
        goalManager.ListGoalsDetails();
        goalManager.SaveGoals();
        goalManager.LoadGoals();
        
        Console.WriteLine("\nScore:");
        goalManager.DisplayPlayerInfo();
    }
}