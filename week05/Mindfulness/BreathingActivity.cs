class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(3);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountdown(3);
            Console.WriteLine();
        }
        DisplayEndingMessage();
        LogActivity(); 
    }
}