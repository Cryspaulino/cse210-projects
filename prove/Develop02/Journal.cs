using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public string _fileName;

    public void Display()
    {
        Console.WriteLine($"Entries: ");

        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveFile(List<Entry> _entries)
    {
        string file = _fileName;
        Console.WriteLine("Saving to file");

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} ~ {entry._prompt} ~ {entry._response}");
            }
        }
    }

    public void LoadFile()
    {
        _entries.Clear();
        string[] allEntries = System.IO.File.ReadAllLines(_fileName);

        foreach (string entry in allEntries)
        {
            string[] parts = entry.Split();
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._response = parts[2];

            _entries.Add(newEntry);
        }
    }
}