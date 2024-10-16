using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment a1 = new MathAssignment("John", "Integrals", "7.1", "41, 42, 43-50");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine(a1.GetHomeworkList());

        WritingAssignment a2 = new WritingAssignment("Samantha Thompson", "Midgets", "A Short History about Midgets");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetWritingInformation());
    }
}