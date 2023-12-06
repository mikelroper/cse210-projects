using System;

public class MenuHelper
{
    private static string displayName {get; set;}
    private static Time time = new Time();
    private static ViewTime viewTime = new ViewTime();
    //string Username = "";

//need to prompt for name and position
//File should save and load automatically.
//all user data shouyld have the same format.
// Menu should be different for manager and employee

    public void SetDisplayNameFromAuthentication()
    {
        // Logic to authenticate the user and retrieve their name
        Console.WriteLine("Please enter your username: ");
        displayName = Console.ReadLine(); // Set the displayName from user input
    }
    
    public static void DisplayMenu()
    {
        Console.WriteLine("Welcome to TimeTracking");
        Console.WriteLine($"Welcome {displayName}.  Please select and option from the menu: ");
        Console.WriteLine("1. Log Time Entry");
        Console.WriteLine("2. View Time");
        Console.WriteLine("3. View User");
        Console.WriteLine("4. Add User");
        Console.WriteLine("5. Update User");
        Console.WriteLine("6. Quit");
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


    public static void LogTimeOptions()  
    {
        Console.WriteLine("Which time option do you want to log? ");
        Console.WriteLine("1. Log Start Time");
        Console.WriteLine("2. Log End Time");
    }

// This needs to be revamped -
    public static void HandleMenuOption(int choice)
    {
        switch (choice)
        {
        case 1:
            LogTimeOptions();
            int timeEntryChoice = GetUserSelectedOption();
            HandleSubMenuTimeOption(timeEntryChoice);
            break;
        
        case 2:
            if (empOrMgr.GetUserTitle(displayName) == "EMP")
            {
                ViewTime.ViewTimeEmp(displayName);
            }
            else 
            {
                ViewTime.ViewTimeMGR();
            }
            break;
        
        case 3:
            if (empOrMgr.GetUserTitle(displayName) == "MGR")
            {
                Users.DisplayAllUsers();
            }
            else
            {
                Console.WriteLine("Option not authorized");
            }
            break;

        case 4:
            if (empOrMgr.GetUserTitle(displayName) == "MGR")
            {
                Users.CreateNewUser();
            }
            else
            {
                Console.WriteLine("Option not authorized");
            }
            break;

        case 5: 
            if (empOrMgr.GetUserTitle(displayName) == "MGR")
            {
                //This requires a submenu which will have case logic to call the differnt methods in updateUYser.cs
                //UpdateUser.UpdateUserOption();
            }
            else
            {
                Console.WriteLine("Option not authorized");
            }
            break;
            case 6:
                //quit
                break;
        }
    }
    
    public static void HandleSubMenuTimeOption(int choice)
    {
        switch (choice)
        {
            case 1:
                time.LogStartTime();
                Console.WriteLine("Start time logged.");
                
                break;
            case 2:
                time.LogEndTime();
                Console.WriteLine("End time logged.");
                break;
        }

    }

    public static void HandleSubMenuUpdateUserOption(int choice)
    {
        switch (choice)
        {
            case 1:
                time.LogStartTime();
                Console.WriteLine("Start time logged.");
                
                break;
            case 2:
                time.LogEndTime();
                Console.WriteLine("End time logged.");
                break;
        }

    }
}
