using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted < _target)
        {
            Console.WriteLine($"Good job! You recorded '{_shortName}' and earned {GetPoints()} points. Progress: {_amountCompleted}/{_target}");
        }
        else if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You completed '{_shortName}' {_target} times and earned a bonus of {_bonus} points!");
            _points += _bonus;
        }
        else
        {
            Console.WriteLine($"You have already completed the goal '{_shortName}' the required number of times.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}
