using System;

public class Activity
{
    // member variables
    private string _name;
    private string _description;
    protected int _duration;

    // constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n\n");
        Console.WriteLine($"{_description}\n\n");

        // asks for duration
        Console.Write("How long, in seconds, would you like for your session? ");

        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            _duration = duration;
        }
        else
        {
            // if no duration is given, 30 secs is default length
            Console.WriteLine("Invalid duration. Setting default duration to 30 seconds.");
            _duration = 30;
        }

    }

    public void DisplayEndingMessage()
    {
        // displays end message
        Console.WriteLine($"\nWell Done!\n");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}!");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        int counter = 0;
        while (counter < seconds)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b"); 

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b"); 

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");

            counter++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }
}