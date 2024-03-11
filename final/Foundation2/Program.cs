using System;
using System.Collections.Generic;

public class Journal 
{
    public List<JournalEntry> entries;
    public Journal()
    {
        entries = new List<JournalEntry>();
    }
    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }
    public List<JournalEntry> GetEntries()
    {
        return entries:
    }
}
