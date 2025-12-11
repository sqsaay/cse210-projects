namespace EternalQuest;

class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nEternal Quest Menu");
                Console.WriteLine("1. Create goal");
                Console.WriteLine("2. List goals");
                Console.WriteLine("3. Record event");
                Console.WriteLine("4. Show score");
                Console.WriteLine("5. Save goals");
                Console.WriteLine("6. Load goals");
                Console.WriteLine("7. Quit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal(manager);
                        break;
                    case "2":
                        manager.ListGoals();
                        break;
                    case "3":
                        RecordEvent(manager);
                        break;
                    case "4":
                        Console.WriteLine("Score: " + manager.Score);
                        break;
                    case "5":
                        manager.Save();
                        break;
                    case "6":
                        manager.Load();
                        break;
                    case "7":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void CreateGoal(GoalManager manager)
        {
            Console.WriteLine("Choose type: 1=Simple, 2=Eternal, 3=Checklist");
            string type = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string desc = Console.ReadLine();
            Console.Write("Points: ");
            int points = int.Parse(Console.ReadLine());

            if (type == "1")
            {
                manager.AddGoal(new SimpleGoal(name, desc, points));
            }
            else if (type == "2")
            {
                manager.AddGoal(new EternalGoal(name, desc, points));
            }
            else if (type == "3")
            {
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
            }
            else
            {
                Console.WriteLine("Invalid type.");
            }
        }

        static void RecordEvent(GoalManager manager)
        {
            manager.ListGoals();
            Console.Write("Goal number: ");
            int index;
            if (int.TryParse(Console.ReadLine(), out index))
            {
                manager.RecordEvent(index - 1);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
