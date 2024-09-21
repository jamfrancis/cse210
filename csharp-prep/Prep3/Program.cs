using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        do
        {
            
            Console.WriteLine("The magic number has been chosen.");
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,101);

            int user = 0;
            int i = 1;

            while (user != number)
            {
                Console.Write("What is your guess? ");
                user = int.Parse(Console.ReadLine());

                if (user < number)
                {
                    Console.WriteLine("Higher");
                    i++;
                }
                else if (user > number)
                {
                    Console.WriteLine("Lower");
                    i++;
                }
            
                else
                {
                    Console.WriteLine($"You guessed it! It took you {i} guesses!");
                    Console.Write("Do you want to continue? ");
                    response = Console.ReadLine();
                }
            }
        } while (response == "yes");

    }
}