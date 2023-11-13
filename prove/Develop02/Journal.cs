using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        
    }

    public void SaveToFile(string file)
    {      
        string files = $"{file}.txt";

        using (StreamWriter showFile = new StreamWriter(files))
        {
            foreach (Entry ent in _entries)
            {
                showFile.WriteLine($"{ent._date}~{ent._promptText}~{ent._entryText}");
                
            }
        }

    }

    public void LoadFromFile(string file)
    {
        string filename =  $"{file}.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}