using System;
using System.Numerics;

public class FractionFormatter
{
    public static string GetFractionString(int numerator, int denominator)
    {
        // Create a Fraction object
        var fraction = new Fraction(numerator, denominator);

        // Return the fraction as a string in the form "3/4"
        return $"{fraction.Numerator}/{fraction.Denominator}";
    }

    // Example usage
    public static void Main()
    {
        int numerator = 3;
        int denominator = 4;
        string result = GetFractionString(numerator, denominator);
        Console.WriteLine($"The fraction {numerator}/{denominator} as a string: {result}");
    }
}