using System;
using Homework;

class Program
{
    static void Main(string[] args)
    {
    Assignment assignment1 = new Assignment("Samantha", "Fractions");
    Console.WriteLine(assignment1.GetSummary());

    MathAssignment mathAssignment1 = new MathAssignment("Alejandra", "Fractions", "7.3", "8-19");
    Console.WriteLine(mathAssignment1.GetSummary());
    Console.WriteLine(mathAssignment1.GetHomeworkList());

    WriteAssignment writeAssignment1 = new WriteAssignment("Samantha Salazar", "European History", "The Causes of World War II");
    Console.WriteLine(writeAssignment1.GetSummary());
    Console.WriteLine(writeAssignment1.GetWritingInformation());

    }
}