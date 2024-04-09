using System;
using System.Collections.Generic;
using LibraryManagementSpace;


public class Library
{
    private List < Book > books = new List < Book >();
    private List < Patron > patrons = new List< Patron > ();
    public void AddBook ( Book book)
    {
        books.Add ( book );    
    }
    public void AddPatron ( Patron patron)
    {
        patrons.Add (patron);
    }

}