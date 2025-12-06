class ReflectingActivity : Activity
{
    private List<string> prompts = new List<string> {
        "Think of a time you stood up for someone.",
        "Think of a time you overcame a challenge.",
        "Think of a time you helped someone in need."
    };

    private List<string> questions = new List<string> {
        "Why was this experience meaningful?",
        "What did you learn about yourself?",
        "How can you apply this lesson today?"
    };

    public ReflectingActivity() 
        : base("Reflecting Activity", "This activity helps you reflect on times when you showed strength or resilience.") { }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Console.WriteLine("Consider the following questions:");
        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine(questions[rand.Next(questions.Count)]);
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }
}