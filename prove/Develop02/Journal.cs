using System;
using System.Collections.Generic;
using System.IO;

namespace MyJournalApp
{
    class MyJournalApp
    {
        public List<string> entries;
        public MyJournalApp()
        {
            entries = new List<string>();
        }
        public void AddEntry(string entryText)
        {
            entries.Add(entryText);
        }
        public void DisplayEntries()
        {
            console.WhiteLine("Journal Entries:");
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
        public void LoadFromFile(string filepath)
        {
            try
            {
                entries.Clear();
                string[] lines = filepath.ReadAllLines(filepath);
                entries.AddRange(Lines);
                Console.WriteLine($"Loaded {lines.length} entries from filePath");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Create new journal!");
            }

        }
        public void SaveToFile(string filePath)
        {
            filePath.WriteaAllLines(filePath, entries);
            Console > writeLine($"Saved {entries.count} entries to {filePath}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyJournalApp myJournal = new MyJournalApp();
            Console.WriteLine("Welcome to Your Daily Journal!");
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. AddEntry");
                Console.WriteLine("2. Display Entries");
                Console.WriteLine("3. Load entries");
                Console.WriteLine("4. SAve entries to File");
                Console.WriteLine("5. Quit");

                Console.WriteLine("Please select an option (1-5):");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter your journal entry:");
                        string entryText = Console.ReadLine();
                        myJournal.AddEntry(entryText);
                        break;

                    case "2:
                    myJournal.DisplayEntries();
                        break;

                    case "3:
                    Console.Write("Enter the file path to load from:");
                        string loadPath = Console.ReadLine();

                        myJournal.LoadFromFile(loadPath);
                        break;

                    case "4":
                        Console.Write("Enter the file path to save to:");
                        string savePath = Console.ReadLine();
                        myJournal.SaveToFile(savePath);
                        break;

                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:

                        Console.WriteLine("Invalid selection. Please enter a number 1-5.");
                        break;
                }
            }
        }
    }
}