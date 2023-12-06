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

}