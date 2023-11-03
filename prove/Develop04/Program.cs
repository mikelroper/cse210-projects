/*
Add notes here..................
*/


class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        while (true)
        {
            menu.DisplayMenu();
            int choice = menu.GetUserSelectedOption();

            switch (choice)
            {
                case 1:
                    ExecuteBreathingActivity();
                    break;
                case 2:
                    ExecuteReflectionActivity();
                    break;
                case 3:
                    ExecuteListingsActivity();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0); // Exit the application
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
    }

    static void ExecuteBreathingActivity()
    {
        Breathing breathingActivity = new Breathing("Breathing Activity", "Activity description", "Guidance");
        breathingActivity.StartBreathingActivity();
    }

    static void ExecuteReflectionActivity()
    {
        Reflection reflectionActivity = new Reflection("Reflection Activity", "Activity description", "Guidance");
        reflectionActivity.StartReflectionActivity();
    }

    static void ExecuteListingsActivity()
    {
        Listings listingsActivity = new Listings("Listings Activity", "Activity description", "Guidance");
        listingsActivity.StartListingsActivity();
    }
}
