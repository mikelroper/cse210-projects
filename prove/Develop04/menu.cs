using System;

public class MenuHelper
{
    public string displayName {get; set;}





    public static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Activity Menu");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listings Activity");
        Console.WriteLine("4. Exit");
    }

    public static int GetUserSelectedOption()
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

    public static void HandleMenuOption(int choice)
    {
        switch (choice)
        {
            case 1:
                Breathing breathingActivity = new Breathing("Activity Name", "Activity Description", "Activity Guidance");
                breathingActivity.StartBreathingActivity();
                //Console.Clear(); // Clear the screen
                Console.WriteLine("Activity completed. Press any key to return to the menu.");
                //Console.ReadKey();
                //DisplayMainMenu(menu);
                break;
            
            case 2:
                Reflection reflectionActivity = new Reflection("Activity Name", "Activity Description", "Activity Guidance");
                reflectionActivity.StartReflectionActivity();
                //Console.Clear(); // Clear the screen
                Console.WriteLine("Activity completed. Press any key to return to the menu.");
                //Console.ReadKey();
                //DisplayMainMenu(menu);
                break;
            
            case 3:
                Listings listingActivity = new Listings("Activity Name", "Activity Description", "Activity Guidance");
                listingActivity.StartListingActivity();
                Console.Clear(); // Clear the screen
                Console.WriteLine("Activity completed. Press any key to return to the menu.");
                Console.ReadKey();
                //DisplayMainMenu(menu);
                break;
        }
    }
    
}
