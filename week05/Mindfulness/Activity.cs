class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    // Static dictionary to track activity counts
    private static Dictionary<string, int> activityLog = new Dictionary<string, int>();

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {name}!");
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You completed {duration} seconds of the {name}.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds) { /* same as before */ }
    protected void ShowCountdown(int seconds) { /* same as before */ }

    protected void LogActivity()
    {
        if (activityLog.ContainsKey(name))
            activityLog[name]++;
        else
            activityLog[name] = 1;
    }
    public static void DisplayLog()
    {
        Console.WriteLine("\nActivity Log:");
        foreach (var entry in activityLog)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
    }
}
