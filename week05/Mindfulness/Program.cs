using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            if (choice == "1") new BreathingActivity().Run();
            else if (choice == "2") new ReflectingActivity().Run();
            else if (choice == "3") new ListingActivity().Run();
            else if (choice == "4") Activity.DisplayLog();
            else if (choice == "5") break;
        }
    }
}
