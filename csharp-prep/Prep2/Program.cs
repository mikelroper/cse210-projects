using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your GPA?");
        string answer = Console.ReadLine();
        int gpa = int.Parse(answer);

        string letter = "";

        if (gpa >= 90)
        {
            letter = "A";
        }
        else if (gpa >= 80)
        {
            letter = "B";
        }
        else if (gpa >= 70)
        {
            letter = "C";
        }
        else if (gpa >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (gpa >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}