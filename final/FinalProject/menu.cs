using System;

public class MenuHelper
{
    private static string displayName {get; set;}
    private static Time time = new Time();
    private static ViewTime viewTime = new ViewTime();

    public void SetDisplayNameFromAuthentication()
    {
        // Logic to authenticate the user and retrieve their name
        Console.WriteLine("Please enter your username: ");
        displayName = Console.ReadLine(); // Set the displayName from user input
    }
    
    public static void DisplayMenu()
    {
        
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


    
    public static void UpdateUserData()  
    {
        Console.WriteLine("Which employee data item do you want to update? ");
        Console.WriteLine("1. Log Start Time");  
        Console.WriteLine("2. Log End Time");
        Console.WriteLine("3. Employee Name");
        Console.WriteLine("4. Employee Title");
        Console.WriteLine("5. HireDate");
        Console.WriteLine("6. EndDate");
    }

    public static void HandleMenuOption(int choice)
    {
        List<Users> users = LoadJsonFile.LoadUsersFromJson();
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
                Users newUser = Users.CreateNewUser(); // Capture the created user
                if (newUser != null)
                {
                    Console.WriteLine("New user created:");
                    Console.WriteLine($"Name: {newUser.GetEmployeeName()}; Title: {newUser.GetTitle()}, HireDate: {newUser.GetHireDate()}, Employee Status: {newUser.GetEmpStatus()}");
                }
            }
            else
            {
                Console.WriteLine("Option not authorized");
            }
            break;

        case 5: 
            if (empOrMgr.GetUserTitle(displayName) == "MGR")
            {
                List<Users> allUsers = Users.DisplayAllUsers(); // Get the list of users

        if (allUsers != null && allUsers.Any())
        {
            Console.WriteLine("Enter the number of the user to update:");
            int selectedUserNumber = GetUserSelectedOption(); // Get user input

            if (selectedUserNumber >= 0 && selectedUserNumber < allUsers.Count)
            {
                Users selectedUser = allUsers[selectedUserNumber]; // Get the selected user
                string selectedUserName = selectedUser.GetEmployeeName();
                
                Console.WriteLine("Select the data to update:");
                Console.WriteLine("1. Employee Name");
                Console.WriteLine("2. Title");
                Console.WriteLine("3. Hire Date");
                Console.WriteLine("4. End Date");
                Console.WriteLine("5. Status");
                int updateUserChoice = GetUserSelectedOption();
                HandleSubMenuUpdateUserDataOption(updateUserChoice, selectedUserName);
            }
            else
            {
                Console.WriteLine("Invalid user number.");
            }
        }
        else
        {
            Console.WriteLine("No users to update.");
        }
    }
    else
    {
        Console.WriteLine("Option not authorized");
    }
    break;
            case 6:
                //quit
                Environment.Exit(0);
                break;
        }
    }
    
    public static void HandleSubMenuTimeOption(int choice)
    {
        switch (choice)
        {
            case 1:
                time.LogStartTime(displayName);
                Console.WriteLine("Start time logged.");
                DateTime startTime = time.GetStartHour();
                Console.WriteLine($"Start time: {startTime}");
                break;
            case 2:
                time.LogEndTime(displayName);
                Console.WriteLine("End time logged.");
                DateTime stopTime = time.GetStopHour();
                Console.WriteLine($"Stop time: {stopTime}");
                break;
        }

    }

    public static void HandleSubMenuUpdateUserDataOption(int choice, string employeeName)
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter the new employee name:");
                string newEmployeeName = Console.ReadLine();
                UpdateUser.UpdateUserEmployeeName(employeeName, newEmployeeName);
                break;
            case 2:
                Console.WriteLine("Enter the new title:");
                string newTitle = Console.ReadLine();
                UpdateUser.UpdateUserTitle(employeeName, newTitle);
                break;
            case 3:
                Console.WriteLine("Enter the new hire date (YYYY-MM-DD):");
                string newHireDate = Console.ReadLine();
                UpdateUser.UpdateUserHireDate(employeeName, newHireDate);
                break;
            case 4:
                Console.WriteLine("Enter the new end date (YYYY-MM-DD):");
                string newEndDate = Console.ReadLine();
                UpdateUser.UpdateUserEndDate(employeeName, newEndDate);
                break;
            case 5:
                Console.WriteLine("Enter the new employment status:");
                string newEmpStatus = Console.ReadLine();
                UpdateUser.UpdateUserEmpStatus(employeeName, newEmpStatus);
                break;
            case 6:
                // return to main menu
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

}
