using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);
        string letterGrade = "";


        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        int lastDigit = gradePercentage % 10;
        string signGrade = "";
        if (lastDigit >= 7 && letterGrade != "A" && letterGrade != "F")
        {
            signGrade = "+";
        }
        else if (lastDigit <= 3 && letterGrade != "F")
        {
            signGrade = "-";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}{signGrade}");

    }

}