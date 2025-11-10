using System;

class Program
{

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);

        return userNumber;
    }

    static int SquareNumber(int number)
    {
        number = number * number;
        return number;
    }
    
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"User's name: {name} and Square Number: {number}");
    }
    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        SquareNumber(number);
        DisplayResult(name, number);

        
        /*
        returnType FunctionName (dataType parameter1, dataType parameter2)
        {
            //function body
        }

        void DisplayMessage()
        {
            Console.WriteLine("Hello World!");
        }


        //Single parameter
        void DisplayPersonalMessage(string userName)
        {
            Console.WriteLine($"Hello {username}");
        }

        //Two integers as parameters
        int AddNumbers (int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        //Standalone functions has static "key word"
        static void DisplayMessage()
        {
            Console.WriteLine("Hello World!");
        }

        */      
    }
}