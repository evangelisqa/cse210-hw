using System;
using System.Collections.Generic;

class Program
{
    static void Main ()
    {
       
         var review = new Review
         {
            ProductName = "Laptop",
            Author = user.Username,
            Content = "Great laptop! Highly recommended."
         };
         Console.WriteLine ($"Review for {review.ProductName} by {review.Author}: {review.Content}");
    }
}