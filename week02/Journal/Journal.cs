using System.Collections.Generic;

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
            Console.WriteLine($"Date:{entries._date} - {entries._promptText} \n {entries._entryText}.");
        }

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }

}