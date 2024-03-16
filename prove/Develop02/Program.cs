
class Program
{
    static void Main()
    {
        var myJournal = new Journal();
        var prompts = new List<string>
        {
            "Who was the most interesting person I interacted today?",
            "What was my best part of my day?",
            "How did I see the hand of the Lord in my life today",
            "What was the strongest emtion I felt today?"
            "If I had one thing I could do over today. Why would it be?"
        };
        while (true)
        {
            Console.WriteLine("\nJournaling Program Menu:");
            Console.WriteLine(("1. Write a new entry"));
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    var prompt = prompt[new Random().Next(prompts.Count)];
                    Console.Write($" {prompt}:");
                    var response = Console.ReadLine();
                    myJournal.AddEntry(prompt, response);
                    break;

                case "2":
                    myJournal.DisplayJournal():
                break;

                case "3":
                    Console.Write("Enter the filename to save.");
                    var saeFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    break;

                case "4":
                    Console.Write("Enter the filename to load:");
                    var loadFilename +Console.ReadLine();
                    myJournal.LoadFromFile(LoadFilename):
                break;

                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");

                    return;
                default:

                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;

            }
        }
    }
}



