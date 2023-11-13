/*
Extras - I added comments to the code.
limited Error handling
*/


using System;
using System.Diagnostics;
using System.Text.Json;

class Program
{
static void Main(string[] args)
    {
        bool exit = false;
        int choice = 0;
        /* var a = new Attributes();
        var b = new Attributes(){ActivityName = "dalkjf", }; //this is another way of setting values and properties -  */
         // this will converts text into attributes
        // List<Attributes> activityLog = new List<Attributes>();
        /* activityLog.Add(new Attributes("breathing","more breathing","don't breathe too much")); //activity logs now includes the attributes.
        activityLog.Add(new Attributes("listing","more breathing","don't breathe too much"));
        activityLog.Add(new Attributes("reflection","more breathing","don't breathe too much")); */
        
        //json read from file and output back to file
        /* List<Attributes> savedActivityLog = JsonSerializer.Deserialize<List<Attributes>>(File.ReadAllText(@".\person.json")); //this loads the file - this could then be displayed and updated, changed, etc.
        savedActivityLog.Add(new Attributes("banana","more breathing","don't breathe too much"));
        File.WriteAllText(@".\person.json", JsonSerializer.Serialize<List<Attributes>>(savedActivityLog)); */  // this oututs to a json file using the var a
        
        while (!exit)  //this is shorthand: does not equal false bool specific.
        {
            //DisplayMenu();
            //var m=new Menu(); //instantiates menu - this creates a new instance of a menu object - instantiate means to bring into instance of.
            //m.displayName = "banana"; //this sets the display name found in menu = banana
            // Console.WriteLine(m.displayName); 
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

