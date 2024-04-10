class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("EXERCISE TRACKING");
    Console.WriteLine("******************");
    List<Activity> activities = new List<Activity>();
    //Creating the three types of activities
    RunningActivity runnningActv = new RunningActivity("Running", "19 Sept 2023", 30, 3.0);
    CyclingActivity cyclingActv = new CyclingActivity("Cycling", "19 Oct 2023", 90, 6.5);
    SwimmingActivity swimmActv = new SwimmingActivity("Swimming", "19 Nov 2023", 60, 50);
    //Adding the activities to the list of Activities.
    activities.Add(runnningActv);
    activities.Add(cyclingActv);
    activities.Add(swimmActv);

    foreach (Activity actv in activities)
    {
      actv.displaySummary();
      Console.WriteLine("******************");

    }


  }
}
