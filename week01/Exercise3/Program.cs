using System;

class Program
{
    static void Main(string[] args)
    {
        /* string playAgain = "yes";
         Random randomGenerator = new Random();
         int number = randomGenerator.Next(1, 100);
         Console.WriteLine($"What is your magic number? {number}");

         while (playAgain != "no")
         {
             string inputNumberinText = "";
             Console.WriteLine("What is your guess? ");
             inputNumberinText = Console.ReadLine();
             int inputNumber = int.Parse(inputNumberinText);

             if (inputNumber > number)
             {
                 Console.WriteLine("Higher");
             }
             else if (inputNumber < number)
             {
                 Console.WriteLine("Lower");
             }
             else
             {
                 Console.WriteLine("You guessed it!");
                 Console.WriteLine("Do you want to play again? (yes/no)");
                 playAgain = Console.ReadLine();
                 if (playAgain == "yes")
                 {
                     number = randomGenerator.Next(1, 100);
                     Console.WriteLine($"What is your magic number? {number}");
                 }
             }
         }*/

        string playAgain = "yes";
        Random number = new Random();

        while (playAgain != "no")
        {
            int magicNumber = number.Next(1, 100);
            Console.WriteLine($"What is your magic number? {magicNumber}");
            int userInput = 0;
            int counter = 0;

            while (userInput != magicNumber)
            {
                Console.WriteLine("What is your guess?");
                string userInputText = Console.ReadLine();
                userInput = int.Parse(userInputText);
                counter += 1;

                if (userInput > magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userInput < magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine("Do you want to play again? (yes/no)");
                    playAgain = Console.ReadLine();
                }

            }
            Console.WriteLine($"You took {counter} guesses!");
        }

        
    }
}