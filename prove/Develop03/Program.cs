using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // scripture to memorize
        Reference r1 = new Reference("Alma", 36, 24);
        Scripture s1 = new Scripture(r1, "Yea, and from that time even until now, I have labored without ceasing, that I might bring souls unto repentance; that I might bring them to taste of the exceeding joy of which I did taste; that they might also be born of God, and be filled with the Holy Ghost. Yea, and now behold, O my son, the Lord doth give me exceedingly great joy in the fruit of my labors;");

        // amount of words hidden on every "enter"
        const int WordsToHide = 3;
        
        // repeats until the word is completely hidden
        while (!s1.IsCompletelyHidden())
        {
            Console.Clear();
            // displays the scripture and the reference
            Console.WriteLine(s1.GetDisplayText());

            Console.Write("Press Enter to continue, type 'letter' to toggle Letter Mode, or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (input.ToLower() == "letter")
            {
                // toggles letter mode on or off
                s1.SetLetterMode(!s1.IsLetterMode());
                continue;
            }

            // hides words
            s1.HideRandomWords(WordsToHide);

        }
        Console.Clear();
        Console.WriteLine(s1.GetDisplayText());
    }
}