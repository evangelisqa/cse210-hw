using System;

class Program
{
    static void Main (string[] args)
    {
        DisplayWelcomeMessage();

        string userName = GetUserNumber();
        int userNumber = GetUserNumber();

        int squaredNumber = squareNumber(userName);

        DisplayResult(userName, squaredNumber);
    }
    
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
    static string GetUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        string number = Console.ReadLine();

        return number;
    }
    
    static int GetUserName()
    {
        Console.Write("Please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    
    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    
    static void DisplayResult (string name. int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}