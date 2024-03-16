class Journal
{
    public List<Entry> entries = new List<Entry>();

    public Entry GetEntry(string prompt, string response) => new Entry
    {
        Prompt = prompt,
        Response = response,
        Date = DateTime.Now
    };

    public object AddEntry(string prompt, 
    string response, Entry entry)
    {
        var entry object value = -entry;
        entries.Add(item: Entry);
    }
    public bool DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console > WriteLine($"Response: {entry.Response}\n");
        }
    }
    public void SaveToFile(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}, {entry.Prompt}, {entry.Response}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        entries.Clear();
        try
        {
            using (var reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');
                    if (parts.Length == 3 && DateTimeParse(parts[0], out var date))
                    {
                        entries.Add(new Entry
                        {
                            Date = date,
                            Prompt = promptparts[1],
                            Response = parts[2]
                        });
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Creating a new journal.");
        }
    }

    internal void LoadFromFile(object loadFilename)
    {
        throw new NotImplementedException();
    }

    internal void LoadFromFile(object loadFromFilename)
    {
        throw new NotImplementedException();
    }
}