using System;
using System.IO;

public class Journal
{
    public List<Entry> _entry = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entry.Add(newEntry);

    }
    public void DisplayAll()
    {
        foreach (var entry in _entry)
        {
            entry.Display();
        }
    }

    public void LoadFromFile(string file)
    {
        string[] entries = System.IO.File.ReadAllLines(file);

        foreach (string entry in entries)
        {
            string[] input = entry.Split("|");

            string date = input[0];
            string promptText = input[1];
            string entryText = input[2];
            string rating = input[3];

            Entry loadedEntry = new Entry(new PromptGenerator())
            {
                _date = date,
                _promptText = promptText,
                _entryText = entryText,
                _rating = int.Parse(rating)
            };

            _entry.Add(loadedEntry);
        }
    }
        

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (var entry in _entry)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._rating}");
            }
        }
    }

}