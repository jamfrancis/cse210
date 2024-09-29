using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the most memorable moment of your day?",
        "What did you learn or discover today?",
        "What are you grateful for today?",
        "What is one thing you'd like to improve about yourself?",
        "What is something you've been putting off?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(_prompts.Count);
        return _prompts[randomNumber];
    }
}