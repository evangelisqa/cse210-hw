using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcomeMessage();

       string userName = GetUserName();
       int userNumber = GetUserName();
       

       int squaredNumber = squareNumber(userNumber);

       DisplayResult(userName, squaredNumber);
    }
    static string GetUserName()
    {
        Console.Write("Welcome to the program:");
    }
    static string GetUserName()
    {
        Console.Write("Please enter your name:");
        string name = Console.ReadLine();
        
        return name;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}