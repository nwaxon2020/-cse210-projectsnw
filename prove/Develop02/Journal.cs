using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries;
    Entry entry = new Entry();

    public void AddEntry(Entry newEntry)
    {

       
    }

    public void DisplayAll()
    {

        Console.WriteLine();
        foreach (Entry ent in _entries)
        {
            ent.Display();
        }
    }

    public void SaveToFile(string file)
    {      
        string files = $"{file}.txt";

        using (StreamWriter showFile = new StreamWriter(files))
        {
            foreach (Entry ent in _entries)
            {
                showFile.WriteLine($" {ent._date}-{ent._promptText}\n {ent._entryText}");
            }
        }

    }

    public void LoadFromFile(string file)
    {

    }
}