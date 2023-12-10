using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        Console.WriteLine("Welcome to TimeTracking");
        MenuHelper menuHelper = new MenuHelper(); // Create an instance of MenuHelper
        Console.WriteLine("Jeff is MGR and Alice is EMP");
        menuHelper.SetDisplayNameFromAuthentication();

        while (!exit)  //this is shorthand: does not equal false bool specific.
        {
            
            MenuHelper.DisplayMenu();  
            choice = MenuHelper.GetUserSelectedOption(); 
            if (choice == 4){  
            exit = true;}
            else {
                MenuHelper.HandleMenuOption(choice);
            }
            
        }
        
    }

}