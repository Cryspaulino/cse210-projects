using System;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void Display()
    {
        Console.WriteLine($"Entries: ");

        foreach (Entry e in entries)
        {
            e.Display();
        }
    }
}