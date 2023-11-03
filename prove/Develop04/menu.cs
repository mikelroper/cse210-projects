using System;

public class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Activity Menu");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listings Activity");
        Console.WriteLine("4. Exit");
    }

    public int GetUserSelectedOption()
    {
        Console.Write("Select a choice from the menu: ");
        int choice;

        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid choice. Please enter a valid option.");
            Console.Write("Select a choice from the menu: ");
        }

        return choice;
    }
}
