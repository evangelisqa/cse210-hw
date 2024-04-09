using System;
using System.Collections.Generic;


public class Program
{
    static void Main()
    {
        var library = new Library();
        var book1 = new PhysicalBook{ Title = "Harry Potter", Author = "JK Rowling", IsAvailable - true,
        ISBN = "123456789", Location = "Fiction Section"};
        var book2 = new EBook { Title = "1980", Author = "Evangelis Albesa",
        IsAvailable = false, Format = "PDF",
        DownloadLink = "sample.com/1980.pdf"};

        var patron = new Patron { Name = "Evan", ContactInfo = "evy@gmail.com",
        IsMember = true};

        library.AddBook ( book1);
        library.AddBook ( book2 );
        library.AddPatron (patron);

        book1.DisplayDetails();
        book2.DisplayDetails();

    }
}