using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace ListingActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listing Activity");
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many items as you can in args certain area.");
            Console.WriteLine("Let's get started:\n");

            //Input duration in seconds
            Console.Write("Enter the duation (in seconds):");
            if
            (!int.TryParse(Console.ReadLine(), out int duration))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the duration.");
                return;

            }
            // Prompts
            List<string> prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you helped this week?",
                "When you have felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            Random random = new Random();

            // Choose a random prompt
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine($"\nPrompt:{prompts}\n");

            //Countdonw
            Console.WriteLine("Get ready to list item!");
            for (int i = 3; i >= 1; i--)
            {
                Console.Write($"{i}....");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Go!\n");
            //Gather user input
            List<string> items = new List<string>();
            while (duration > 0)
            {
                Console.Write("Enter an item (or type 'done) to finish):");
                string input = Console.ReadLine();
                if (input.ToLower() == "donne")
                    break;
                items.Add(input);
                duration -= 2;
            }

            // Show the number of items entered
            Console.WriteLine("\nFinishing Message: Reflect on the positive aspects of your life.Gratitude is powerful.");
            Console.WriteLine("You've completed the Listing Activity.");

        }

    }
}