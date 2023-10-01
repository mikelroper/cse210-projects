using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Enter the username:");
        string username = Console.ReadLine();

        return username;
    }


    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int fav_num = int.Parse(Console.ReadLine());

        return fav_num;
    }

    static int SquareNumber(int fav_num)
    {
        int square = fav_num * fav_num;
        return square;
    }
    
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
1
}