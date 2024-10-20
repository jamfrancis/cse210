using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = _duration;

        Console.Clear();
        Console.WriteLine("Get Ready....\n");
        ShowSpinner(5);

        int elapsedTime = 0;
        while (elapsedTime < duration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(2);
            elapsedTime += 2;
            Console.WriteLine();


            Console.Write("Breathe out...");
            ShowCountDown(5);
            elapsedTime += 5;
            Console.WriteLine();


            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}