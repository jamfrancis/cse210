using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity()
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many items as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = _duration;
        string prompt = GetRandomPrompt();

        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---\n");
        Console.Write("You may begin in ");
        ShowCountDown(3);

        Console.Clear();

        List<string> userItems = GetListFromUser(duration);

        _count = userItems.Count;
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser(int duration)
    {
        List<string> userItems = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            userItems.Add(input);

        }

        return userItems;
    }
}