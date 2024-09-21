using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int number = int.Parse(magic);

        Console.Write("What is your guess? ");
        string response = Console.ReadLine();
        int user = int.Parse(response);

        // while (user != number)
        // {
            if (user < number)
            {
                Console.WriteLine("Higher");
            }
            if (user > number)
            {
                Console.WriteLine("Lower");
            }
        // }
    }
}