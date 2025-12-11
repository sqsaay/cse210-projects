class ListingActivity : Activity
{
    private List<string> prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some personal heroes of yours?"
    };

    public ListingActivity() 
        : base("Listing Activity", "This activity helps you recognize positive aspects of your life.") { }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Console.WriteLine("Start listing items:");
        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }
        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
        LogActivity();
    }

}