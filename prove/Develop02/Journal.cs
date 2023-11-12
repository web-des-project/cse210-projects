using System;
using System.IO;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry _entryText)
    {   
        _entries.Add(_entryText);
    }

    public void DisplayAll()
    {
        Console.WriteLine(">>Journal Entries<<");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string line = $"Date: {entry._date} Prompt:{entry._promptText} Entry: {entry._entryText}"; 
                outputFile.WriteLine(line);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Your file has been saved");
    }

    public void LoadFromFile(string file)
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] fileEntry = line.Split(",");

                if (fileEntry.Length >= 3)
                {
                    string loadedDate = fileEntry[0];
                    string loadedPrompt = fileEntry[1];
                    string loadedEntry = fileEntry[2];

                    Entry entry = new Entry
                    {
                        _date = loadedDate,
                        _promptText = loadedPrompt,
                        _entryText = loadedEntry
                    };

                    _entries.Add(entry);
                }
                else
                {   
                    Console.WriteLine($"{line}");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Your file ~{file}~ has been loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the file: {ex.Message}");

        }

    }


    
}