using System;

public class ReflectingActivity : Activity
{
    // member variables
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")

    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = _duration;
        
        DisplayPrompt();
        DisplayQuestions(duration);

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        // gets a random prompt
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        // gets a random question
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.Clear();

        // displays the prompt
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();
    }

    public void DisplayQuestions(int duration)
    {
        // displays question into
        Console.WriteLine("\nNow, reflect on the following questions as they related to this experience.");
        Console.WriteLine($"You may begin in ");
        ShowCountDown(3);

        // keeps track of the elapsed time
        int elapsedTime = 0;
        while (elapsedTime < duration)
        {
            // displays the question
            string question = GetRandomQuestion();
            Console.WriteLine($"> {question}");
            ShowSpinner(3);
            elapsedTime +=3;
        }
    }
}