using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while(true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
        

        int choice = int.Parse(Console.ReadLine());
            
        if (choice == 1){
            Entry newEntry = new Entry(new PromptGenerator());
            Console.WriteLine(newEntry._promptText);
            newEntry.PromptForEntry();
            journal.AddEntry(newEntry);

        }
        else if (choice == 2){
            journal.DisplayAll();
        }
        else if (choice == 3){
            Console.Write("Enter filename: ");
            string file = Console.ReadLine();
            journal.LoadFromFile(file);
        }
        else if (choice == 4){
            Console.Write("Enter filename: ");
            string file = Console.ReadLine();
            journal.SaveToFile(file);
        }
        else if (choice == 5){
            return;
        }
        else{
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
        }
        



        }
    }
}