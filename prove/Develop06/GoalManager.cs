using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private const string FileName = "goals.txt";

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void ResetFile()
    {
        Console.WriteLine("Are you sure? Type 'Y' to permanently reset!");

        string input = Console.ReadLine();
        if (input?.ToUpper() == "Y")
        {
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
            }

            _goals.Clear();
            _score = 0;
            Console.WriteLine("Goals reset successfully.");
        }
    }
    public void Start()
    {
        LoadGoals(FileName);
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Reset");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    RecordEventMenu();
                    break;
                case "4":
                    ResetFile();
                    break;
                case "5":
                    SaveGoals(FileName);
                    Console.WriteLine("Exiting and saving goals...");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }
    }

    public void CreateNewGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which kind of goal would you like to create? ");

        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("Write a short description: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus amount: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        Console.WriteLine("Goal created!\n");
    }

    public void RecordEventMenu()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index;
        
        if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= _goals.Count)
        {
            index -= 1;
            _goals[index].RecordEvent();
            _score += _goals[index].GetPoints();
            Console.WriteLine($"Congratulations! You have earned {_goals[index].GetPoints()} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }


   public void SaveGoals(string filename)
{
    List<string> lines = new List<string>();

    lines.Add(_score.ToString());

    foreach (Goal goal in _goals)
    {
        lines.Add(goal.GetStringRepresentation());
    }

    using (StreamWriter writer = new StreamWriter(filename, false))
    {
        foreach (string line in lines)
        {
            writer.WriteLine(line);
        }
    }

    Console.WriteLine("Goals saved successfully.");
}

    public void LoadGoals(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
            {   
                string scoreLine = reader.ReadLine();
                if (int.TryParse(scoreLine, out int loadedScore))
                {
                    _score = loadedScore; 
                }
                else
                {
                    Console.WriteLine("Error: Unable to load the total score.");
                    return;
                }

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length > 0)
                    {
                        string goalType = parts[0];

                        if (goalType == "SimpleGoal" && parts.Length >= 5)
                        {
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);
                            bool isComplete = bool.Parse(parts[4]);

                            SimpleGoal goal = new SimpleGoal(name, description, points);
                            if (isComplete) goal.RecordEvent();
                            _goals.Add(goal);
                        }
                        else if (goalType == "EternalGoal" && parts.Length >= 4)
                        {
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);

                            _goals.Add(new EternalGoal(name, description, points));
                        }
                        else if (goalType == "ChecklistGoal" && parts.Length >= 7)
                        {
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);
                            int amountCompleted = int.Parse(parts[4]);
                            int target = int.Parse(parts[5]);
                            int bonus = int.Parse(parts[6]);

                            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                            for (int i = 0; i < amountCompleted; i++)
                            {
                                goal.RecordEvent();
                            }
                            _goals.Add(goal);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Warning: Invalid line format in the file.");
                    }
                }

                Console.WriteLine("Goals loaded successfully.");
            }
        }
}
