using System;

public class Entry
{
    public string _date = DateTime.Now.ToString("MM/dd/yyyy");

    public string _promptText;


    public string _entryText;

    public int _rating;

    public Entry(PromptGenerator promptGenerator)
    {
        _promptText = promptGenerator.GetRandomPrompt();

    }

    public void PromptForEntry()
    {
        Console.Write("> ");
        _entryText = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("How are you on a scale of 1-5? (1 = bad, 5 = good)");
            Console.Write("> ");
            _rating = int.Parse(Console.ReadLine());
            if (_rating >= 1 && _rating <= 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 5");
            }

        }
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine($"You were feeling a {_rating}/5.");
    }
}