namespace EternalQuest;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public int Score
    {
        get { return _score; }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + _goals[i].GetDetailsString());
        }
    }

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count)
        {
            return;
        }
        int earned = _goals[index].RecordEvent();
        _score += earned;
        Console.WriteLine("Points earned: " + earned + ". Total score: " + _score);
    }

    public void Save()
    {
        using (StreamWriter writer = new StreamWriter("Goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.ToSaveString());
            }
        }
        Console.WriteLine("Goals saved to Goals.txt");
    }

    public void Load()
    {
        if (!File.Exists("Goals.txt"))
        {
            Console.WriteLine("Goals.txt not found.");
            return;
        }

        string[] lines = File.ReadAllLines("Goals.txt");
        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i])) continue;
            Goal goal = Goal.FromSaveString(lines[i]);
            _goals.Add(goal);
        }

        Console.WriteLine("Goals loaded from Goals.txt. Current score: " + _score);
    }
}