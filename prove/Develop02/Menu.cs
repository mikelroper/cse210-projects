using System;
using System.Collections.Generic;

public class Menu
{
    private List<string> _menuList;

    public Menu()
    {
        _menuList = new List<string>
        {
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "17. Disable Prompts",
            ""
        };
    }

     public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following options:");
        foreach (var option in _menuList)
        {
            Console.WriteLine(option);
        }
        Console.Write("> ");
    }
}