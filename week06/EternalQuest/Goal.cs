using System;

namespace EternalQuest;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    protected Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string ShortName
    {
        get { return _shortName; }
    }

    public string Description
    {
        get { return _description; }
    }

    public int Points
    {
        get { return _points; }
    }

    public abstract int RecordEvent();
    public abstract string GetDetailsString();
    public abstract string ToSaveString();

    public static Goal FromSaveString(string line)
    {
        string[] parts = line.Split('|');
        string type = parts[0];

        if (type == "Simple")
        {
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);
            bool isComplete = bool.Parse(parts[4]);
            return new SimpleGoal(name, desc, points, isComplete);
        }
        else if (type == "Eternal")
        {
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);
            return new EternalGoal(name, desc, points);
        }
        else if (type == "Checklist")
        {
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);
            int target = int.Parse(parts[4]);
            int amountCompleted = int.Parse(parts[5]);
            int bonus = int.Parse(parts[6]);
            return new ChecklistGoal(name, desc, points, target, bonus, amountCompleted);
        }
        else
        {
            throw new InvalidDataException("Unknown goal type: " + type);
        }
    }
}