using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mime;
using System.Reflection.Metadata;

class Program
{
    static void Main ()
    {
        // Simulate adding review
        var review = new Review
        {
            ProductName = "Laptop",
            Authorization = UserStringHandle.Username,
            ContentDisposition = "Great laptop! Highly recommended."
        };
        Console.WriteLine($"Review for {review.ProductName} by {review.Author}: {review.Content}");
    }
}