using System;

class Program
{
    static void Main(string[] args)
    {        
        // variable to keep the program running
        bool running = true;
        while(running)
        {
            // menu
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start relecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string user = Console.ReadLine();

            if (user == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (user == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (user == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (user == "4")
            {
                // ends the program
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid Input! Enter a number between 1 and 4!");
            }

            // exceeding requirements: Added a default length of activity

        }
    }
}