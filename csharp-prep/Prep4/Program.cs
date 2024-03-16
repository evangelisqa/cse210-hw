using System;
using System.Collections.Generic;
List<int> numbers = new List<int>();

// Generate a random magic number between 1 and 100 or more
int userNumber = -1;
while (userNumber != 0)
{
    Console.Write("Enter a number (0 to quit):");

    string userResponse = Console.ReadLine();
    userNumber = int.Parse(userResponse);

    // Only add the numer to the list if it not 0
    if (userNumber != 0)
    {
        numbers.Add(userNumber);
    }
}
// Part 1 Compute the sum
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}

Console.WriteLine($"The sum is: {sum}");

//Part 2 Compute the average
// Before dividing, convert the sum to a floating-point number to maintain decimal precision.
float average = ((float)sum) / numbers.Count;
Console.WriteLine($"The average is: {average}");

// Part 3: Find the max

int max = numbers[0];

foreach (int number in numbers)
{
    if (number > max)
    {
        max = number;
    }
}

Console.WriteLine($"The max is: {max}");
