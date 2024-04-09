using System;
using System.Collections.Generic;
using System.Net;

namespace LibraryManagementSpace
{
    // According class for books
    public class Book
    {
        public string Title { get; set;}
        public string Author { get; set;}
        public bool IsAvailable { get; set;}
    }
        public virtual void DisplayDetails()
        {
            Console.WriteLine ($"Title: {Title},Author: {Author}, Available: {IsAvailable}");
        }
}