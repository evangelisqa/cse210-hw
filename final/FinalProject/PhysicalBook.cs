using System;
using System.Collections.Generic;
using LibraryManagementSpace;

public class PhysicalBook : Book
{
    public string ISBN { get; set;}
    public string Location { get; set;}
    
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"ISBN: {ISBN}, Location:{Location}");
    }
}
