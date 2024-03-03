using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName(;)
        int userName = PromptUserName();

        int squareNumber = squareNumber(userNimber);

        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!")
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserName()
    {
        Console.Write("Please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squareNumber(int numer)
    {
        int square = Number * Number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}