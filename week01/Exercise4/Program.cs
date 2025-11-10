using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {


        /*List<string> words = new List<string>();
        words.Add("apple");
        /*Size of list 
        Console.WriteLine(words.Count);

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        
        for (int i=0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }*/

        List<int> numbers = new List<int>();
        int userInput = -1;
        int sum = 0;
        int largestNumber = 0;
        int minimunNumber = 100;

        while (userInput != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            Console.WriteLine("Enter a number: ");
            string userInputinText = Console.ReadLine();
            userInput = int.Parse(userInputinText);

            if (userInput != 0)
            {
                numbers.Add(userInput);

            }

        }

        //Compute the sum

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Compute the max number
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");

        //Compute the smallest positive number
        foreach (int number in numbers)
        {
            if (number < minimunNumber)
            {
                if (number > 0)
                {
                    minimunNumber = number;
                }
            }
        }
        Console.WriteLine($"The smallest positive is: {minimunNumber}");

        //Sort list from smallest to largest number
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        

        
        
       
        

        



    }
}