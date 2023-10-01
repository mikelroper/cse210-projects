using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");
        Console.WriteLine("Please select one of the following options.");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("> ");
        
        string userInput = Console.ReadLine();
        // convert user input to int if possible
        if (int.TryParse(userInput, out int menuOption))
        {
            // if statement
            if (menuOption == 1)
            {
                // call prompt function and store new text as string var.
            }
            else if (menuOption == 2)
            {
                // display text from file in load file function.
            }
            else if (menuOption == 3)
            {
                // call load file function.
            }
            else if (menuOption == 4)
            {
                // call save file function.
            }
            else if (menuOption == 5)
            {
                // Quit application.
            }
            else
            {
                Console.WriteLine("Invalid menu option");
            }
        }


        // Reader input and call save file method
        // Read user input
        string userData = Console.ReadLine();

        // Specify the file name
        string fileName = "myFile.txt";

        // Create an instance of the SaveFile class
        SaveFile saver = new SaveFile();

        // Call the SaveDataToFile method to save the user's data
        saver.SaveDataToFile(fileName, userData);

        Console.WriteLine("Data saved successfully.");




        // date time
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
    
    }
}