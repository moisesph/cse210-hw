using System.Collections.Generic;
using System;
using System.IO;

public class Journal
{

    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entries in _entries)
        {
            entries.Display();
        }

    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outsideFile = new StreamWriter(file))
        {
            foreach (Entry entries in _entries)
            {
                outsideFile.WriteLine($"{entries._date},{entries._promptText},{entries._entryText}");
            }
        }

    }

    public void LoadFromFile(string file)
    {
        string[] information = System.IO.File.ReadAllLines(file);

        foreach (string data in information)
        {
            Entry loadedEntry = new Entry();

            string[] sections = data.Split(",");
            loadedEntry._date = sections[0];
            loadedEntry._promptText = sections[1];
            loadedEntry._entryText = sections[2];

            AddEntry(loadedEntry);
        }
    }

}