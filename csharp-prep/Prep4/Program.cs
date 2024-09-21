using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int user = 1;
        do 
        {
        Console.Write("Enter Number: ");
        user = int.Parse(Console.ReadLine());
        if (user != 0)
        {
            numbers.Add(user);
        }
        } while (user != 0);

        int sum = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if (largest < number)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        double average = sum / (double)numbers.Count;
        Console.WriteLine($"The average is: {average}");;
        Console.WriteLine($"The largest number is: {largest}");
        
    }
}