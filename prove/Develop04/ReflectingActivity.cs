using System;
using System.Collections.Generic;
using System.Threading;

namespace ReflectionActivity
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Reflection Activity.");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strngth and resilience.");
            Console.WriteLine("Recognize the power you have and how you can use it in other aspects of your life.\n");
            // To have user input for duration (in secondds)
            Console.Write("Enter the duration (in seconds):");
            if
            (!int.TryParse(Console.ReadLine(), out int duration))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the duration.");
                return;
            }
            // Prompts list
            List<string> prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did somethig truly sellfless."
            };
            // Reflection questions
            List<string> questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "Hoe did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than the other time when you were not as successful?",
                "What is your favourite thing about this experience?",
                "What could you learn from this experience?",
                "How can you keep this experience in mind in the future?"
            };
            Random random = new Random();
            while (duration > 0)
            {
                string prompt = prompts [ random.Next(prompts.Count)];
                Console.WriteLine($"\nPrompt: {prompt}\n");
                Thread.Sleep(2000); 
                // Pause for 2 sec per question
                duration -=2;

            }
        }
    }
}