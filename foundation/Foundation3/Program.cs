using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Running r1 = new Running(new DateTime(2024, 10, 26), 30, 3.0);
        Biking b1 = new Biking(new DateTime(2024, 10, 27), 60, 15.0);
        Swimming s1 = new Swimming(new DateTime(2024, 10, 28), 45, 30);

        List<Activity> activities = new List<Activity> { r1, b1, s1 };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}