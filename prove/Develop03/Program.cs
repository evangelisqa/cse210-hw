using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture ("John 3:16", "For God so loved thecworld that He gave His one and only Son, that whoever 
        believes in Him shall not perish but have eternal life.");

        Console.Clear();
        scripture .DisplayScripture();

        while (true)
        {
            Console.WriteLine("Press enter to hide a word or type wuit to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();
                scripture.HideWord();
                scripture.DisplayScripture();

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("Congratulations, you have memorized the scripture");
                    break;
                }
            }
        }

    }
}



