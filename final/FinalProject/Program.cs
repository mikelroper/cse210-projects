using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

class Program
{
static void Main(string[] args)
    {
        //List<BaseGoal> goals = LoadExistingGoals();
        bool exit = false;
        int choice = 0;
        
        while (!exit)  //this is shorthand: does not equal false bool specific.
        {
            MenuHelper.DisplayMenu();  // calls a function of the class menu  //a class is what collection of properties and functions.
            choice = MenuHelper.GetUserSelectedOption(); //here the class name is used - because static is used in the method.  don't mix static
            if (choice == 4){  //static methods are dragged along with the rest of the program, which can cause memory/performance issues.
            exit = true;}
            else {
                MenuHelper.HandleMenuOption(choice);
            }
            
        }
        
    }
    /* static List<BaseGoal> LoadExistingGoals()
    {
        List<BaseGoal> existingGoals = new List<BaseGoal>();

        // Load goals from the JSON file, if available
        if (File.Exists("goals.json"))
        {
             string json = File.ReadAllText("goals.json");
            if (!string.IsNullOrWhiteSpace(json))
            {
                try
                {
                    existingGoals = JsonSerializer.Deserialize<List<BaseGoal>>(json);
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Error deserializing JSON: {ex.Message}");
                    // Handle deserialization error
                }
            }
        }
        else
        {
            Console.WriteLine("Goals file not found. Creating a new file.");
            File.Create("goals.json").Close();
        }

        return existingGoals;
    } */

}