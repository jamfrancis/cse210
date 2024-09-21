using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int number = int.Parse(magic);

        int user = 0;

        while (user != number)
        {
            Console.Write("What is your guess? ");
            user = int.Parse(Console.ReadLine());

            if (user < number)
            {
                Console.WriteLine("Higher");
            }
            else if (user > number)
            {
                Console.WriteLine("Lower");
            }
        
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}