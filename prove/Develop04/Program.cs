using System;
using System.Threading;

namespace BreathingActivity
{
    class BreathingActivity
    {
        public BreathingActivity()
        {
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Breathing Activity");
            Console.WriteLine("This activity will help you relax by guiding you through slow, deliberate breathing. Clear your mind and focus on your breath.");
            Console.WriteLine("Let's begin:\n");

            // Get user input for duration (in seconds)
            Console.Write("Enter the duration (in seconds): ");
            if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer for the duration.");
                return;
            }

            Console.WriteLine("\nStarting Message: Take a moment to find a comfortable position. Close your eyes if you'd like. We'll start by inhaling deeply and exhaling slowly.");

            // Each breath cycle takes 4 seconds (2 seconds inhale + 2 seconds exhale)
            int breathCycleDuration = 4;
            while (duration >= breathCycleDuration)
            {
                Console.WriteLine("\nBreath in...");
                Thread.Sleep(2000); // Pause for 2 seconds
                Console.WriteLine("Breath out...");
                Thread.Sleep(2000); // Pause for 2 seconds

                duration -= breathCycleDuration;
            }

            if (duration > 0)
            {
                // Handle remaining time
                Console.WriteLine("\nBreath in...");
                Thread.Sleep(duration * 1000 / 2); // Pause for remaining seconds (half for inhale)
                Console.WriteLine("Breath out...");
                Thread.Sleep(duration * 1000 / 2); // Pause for remaining seconds (half for exhale)
            }

            Console.WriteLine("\nFinishing Message: Well done! You've completed the breathing activity. Take a moment to notice how you feel. Remember, deep breathing can help reduce stress and promote relaxation.");
        }
    }
}