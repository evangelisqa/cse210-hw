using System;
using System.Collections.Generic;
using System.IO;

public class Entry {
    public string _date;
    public string _promptQuestion;
    public string _entry;

    public void DisplayEntry () {
        Console.WriteLine($"{_date} - {_promptQuestion}  \n'{_entry}'\n");
        
    }
    

 



}