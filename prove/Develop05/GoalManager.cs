using System;
using System.Collections.Generic;

class GoalManager
{
    private List<Goal> goalList = new List<Goal>();
    private int score = 0;
    public void Start()
    {
        //Implementation for starting the goal manager
    }
    public void DisplayInfo()
    {
        //Implementation for displaying user information
    }
    public List<string> ListGoalsName()
    {
        //Implementation for listing goal names
        return goalsList.ConvertAll(Goal => Goal.GetDeatialsString());
    }
    public List<string> ListGoalsDetails()
    {
        //Implementation for listing goal details
        return goalsList.ConvertAll(Goal =>Goal.GetStringRepresentation());
    }
    public void CreateGoals()
    {
        //Implementation for creating goals
        goalsList.Add(new SimpleGoal("Run a marathon", 1000));
        goalsList.Add(new EternalGoal("Read scriptures", 500));
        goalsList.Add(new ChecklistGoal("Attend the temple", 100));
    }
    public void RecordEvent()
    {
        //Implementation for recording events
        goalsList.ForEach(Goal => Goal.RecordEvent());
    }
    public void SaveGoals()
    {
        //Implementation for saving goals
    }
    public void LoadGoals()
    {
        //Implementation for loading goals
    }
}