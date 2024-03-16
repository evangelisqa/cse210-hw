using System;

DisplayWelcomeMessage();

string userName = GetUserNumber();
int userNumber = GetUserName();

int squaredNumber = squareNumber(userNumber);

DisplayResult(userName, squaredNumber);

void DisplayWelcomeMessage()
{
    Console.WriteLine("Welcome to the program!");
}

string GetUserNumber()
{
    Console.Write("Please enter your favorite number:");
    string number = Console.ReadLine();

    return number;
}

int GetUserName()
{
    Console.Write("Please enter your favorite number:");
    int number = int.Parse(Console.ReadLine());

    return number;
}

int squareNumber(int number)
{
    int square = number * number;
    return square;
}

void DisplayResult(string name, int square)
{
    Console.WriteLine($"{name}, the square of your number is {square}");
}
