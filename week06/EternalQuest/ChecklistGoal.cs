using System;

namespace EternalQuest;

public
    class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int earned = _points;

        if (_amountCompleted >= _target)
        {
            earned += _bonus;
        }

        return earned;
    }

    public override string GetDetailsString()
    {
        return "[ ] " + _shortName + " (" + _description + ") — " + _amountCompleted + "/" + _target;
    }

    public override string ToSaveString()
    {
        return "Checklist|" + _shortName + "|" + _description + "|" + _points + "|" + _target + "|" + _amountCompleted + "|" + _bonus;
    }
}



