using System;

public class MenuHelper
{
    public string displayName {get; set;}

//need to prompt for name and position
//File should save and load automatically.
//all user data shouyld have the same format.
// Menu should be different for manager and employee

    public static void DisplayMenu()
    {
        Console.WriteLine("Welcome Goal Tracking");
        Console.WriteLine("1. Log Time");
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


    public static void DisplayGoalMenu()
    {
        Console.WriteLine("The Types of Goals Are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
    }

public static int GetUserGoalSelectedOption()
    {
        Console.Write("Which Type of Goal would you like to create? ");
        int choice;

        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid choice. Please enter a valid option.");
            Console.Write("Which Type of Goal would you like to create? ");
        }

        return choice;
    }


// This needs to be revamped -
    public static void HandleMenuOption(int choice)
    {
        //SimpleGoal createdSimpleGoal; 
        switch (choice)
        {
            case 1:
                DisplayGoalMenu(); // Call DisplayGoalMenu
                int goalTypeChoice = GetUserGoalSelectedOption(); // Get the user's choice for goal type
                HandleSubMenuOption(goalTypeChoice); // Handle the submenu option based on the user's choice
                break;
            
            case 2:
                List<Attributes> loadedGoals = LoadGoalsFromFile.LoadGoalsFromJson();
                LoadGoalsFromFile.DisplayGoals(loadedGoals);
                break;
            
            case 3:
                List<Attributes> loadedGoalsForSave = LoadGoalsFromFile.LoadGoalsFromJson();
                List<BaseGoal> baseGoalsList = loadedGoalsForSave.Select(goal => (BaseGoal)goal).ToList();
                SaveGoalsToFile.SaveGoalsToJson(baseGoalsList); // Call the method to load goals from JSON
                break;
            case 4:
                LoadGoalsFromFile.LoadGoalsFromJson(); // Call the method to load goals from JSON
                break;
            case 5: //record event

                break;
        }
    }
    
    public static void HandleSubMenuOption(int choice)
    {
        //createdSimpleGoal = null;  //add createdEternal and checklist here and in the declaration above?
        switch (choice)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal();
                simpleGoal.CreateSimpleGoal();
                break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal();
                eternalGoal.CreateEternalGoal();
                break;
            case 3:
                ChecklistGoal checklistGoal = new ChecklistGoal();
                checklistGoal.CreateChecklistGoal();
                break;
        }

    }
}
