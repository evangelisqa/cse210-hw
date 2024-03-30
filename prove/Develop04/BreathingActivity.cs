using System;
using System.Diagnostics;
using System.Threading;

namespace BreathingActivity
{
    class Program
    { 
      private static void Main(string[]args)
       
        {
            Console.WriteLine("Breathing Activity");
            Console.WriteLine("This activity will help you relax by guiding you through slow, deliberate breathing. Clear your mind and focus on your breath.");
            Console.WriteLine("Let's begin:\n");

            // Get user input for duration ( in seconds)
            Console.Write("Enter the duration (in seconds):");
            if
            (!int.TryParse(Console.ReadLine(), out int duration))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the duration.");
                return;
            }
            Console.WriteLine("\nStarting Message: Take a moment to find a comfortable position. Close your eyes if you'd like. We'll start by inhaling deeply and exhaling slowly.");
            while (duration > 0)
            {
                Console.WriteLine("\nBreath in....");
                Thread.Sleep(2000); //Pause for 2 seconds
                Console.WriteLine("Breath out....");
                Thread.Sleep(2000); //Pause for 2 seconds

                duration -= 4;
            }
            Console.WriteLine("\nFinishing Message: Well done! You've completed the breathing activity. Take a moment to notice how you feel. Remember, deep breathing can help reduce stress and promote relaxation.");

        }
        
    }
}

        
    