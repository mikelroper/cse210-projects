/*
Extras - I added comments to the code.
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        
        while (true)
        {
            DisplayMainMenu(menu);
        }
    }

    public static void DisplayMainMenu(Menu menu)
    {
        menu.DisplayMenu();
        int choice = menu.GetUserSelectedOption();

        switch (choice)
        {
            case 1:
                Breathing breathingActivity = new Breathing("Activity Name", "Activity Description", "Activity Guidance");
                breathingActivity.StartBreathingActivity();
                //Console.Clear(); // Clear the screen
                Console.WriteLine("Activity completed. Press any key to return to the menu.");
                //Console.ReadKey();
                DisplayMainMenu(menu);
                break;
            
            case 2:
                Reflection reflectionActivity = new Reflection("Activity Name", "Activity Description", "Activity Guidance");
                reflectionActivity.StartReflectionActivity();
                //Console.Clear(); // Clear the screen
                Console.WriteLine("Activity completed. Press any key to return to the menu.");
                //Console.ReadKey();
                DisplayMainMenu(menu);
                break;
            
            case 3:
                Listings listingActivity = new Listings("Activity Name", "Activity Description", "Activity Guidance");
                listingActivity.StartListingActivity();
                Console.Clear(); // Clear the screen
                Console.WriteLine("Activity completed. Press any key to return to the menu.");
                Console.ReadKey();
                DisplayMainMenu(menu);
                break;
            
            case 4:
                Environment.Exit(0);
                break;
            
            default:
                Console.WriteLine("Please enter the number of the menu option.");
                break;
        }
    }
}

