using System;

DisplayWelcomeMessage();

string userName = GetUserName();
int userNumber = GetUserName();


int squaredNumber = squareNumber(userNumber);

DisplayResult(userName, squaredNumber);
string GetUserName()
{
    Console.Write("Welcome to the program:");
}
string GetUserName()
{
    Console.Write("Please enter your name:");
    string name = Console.ReadLine();

    return name;
}
void DisplayResult(string name, int square)
{
    Console.WriteLine($"{name}, the square of your number is {square}");
}
