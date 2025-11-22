using System;

class Program
{
    static void Main(string[] args)
    {
         List<Scripture> library = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"),
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"),
            new Scripture(new Reference("Mosiah", 18, 9),
                "Stand as witnesses of God at all times and in all things"),
            new Scripture(new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be and men are that they might have joy")
        };

        // Pick a random scripture from the library
        Random rand = new Random();
        Scripture scripture = library[rand.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }
        }
    }
}