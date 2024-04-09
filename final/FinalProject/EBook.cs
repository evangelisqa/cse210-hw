using System;
using System.Collections.Generic;
using LibraryManagementSpace;

public class EBook : Book
{
    public string Format { get; set; }
    public string DownloadLink { get; set; }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Format: {Format}, DownloadLink: {DownloadLink}");
    }
}