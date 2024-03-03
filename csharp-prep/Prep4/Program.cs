using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> number = new List<int>();

       // Please note we could use a do-while loop here instead
       int userNumber = -1;
       while (userNumber !=0)
       {
            Console.Write("Enter a number (0 to quit):");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Only add the numer to the list if it not 0
            if (userNumber != 0)
            {
                number.Add(userNumber);
            }
       }
      // Part 1
       int sum = 0;
       foreach (int number in numbers)
       {
            sum  += number;
       }
       Console.WriteLine($"The sum is: {sum}");
       
       //Part 2
       float average = ((float)sum) / numbers.Count;
       Console.WriteLine($"The average is: {average}");

       // Part 3: Find the max
       
       int max = number[0];

       foreach (int number in numbers)
       {
          if (number > max)
       }
    }
    Console.WriteLine ($"The max is: {max}");
}