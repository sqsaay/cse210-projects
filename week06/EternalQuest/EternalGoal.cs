using System;

namespace EternalQuest;

public class EternalGoal : Goal
    {
        public EternalGoal(string shortName, string description, int points)
            : base(shortName, description, points) {}

        public override int RecordEvent()
        {
            return _points;
        }

        public override string GetDetailsString()
        {
            return "[∞] " + _shortName + " (" + _description + ") — +" + _points + " each time";
        }

        public override string ToSaveString()
        {
            return "Eternal|" + _shortName + "|" + _description + "|" + _points;
        }
    }