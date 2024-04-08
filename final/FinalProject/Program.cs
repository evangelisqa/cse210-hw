using System;
using System.Collections.Generic;

class Program
{
    static void Main ()
    {
       
         var review = new Review
         {
            ProductName = "Laptop",
            Author = User.username,
            Content = "Great laptop! Highly recommended."
         };
         Console.WriteLine ($"Review for {review.ProductName} by {review.Author}: {review.Content}");
    }
}