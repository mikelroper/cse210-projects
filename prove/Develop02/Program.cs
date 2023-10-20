/*
There are a number of extras in this code.
1. I added an option to disable prompts.  Not everyone wants them.
2. I added error handling to a number of items with messages so people know what to do
or what the issue is.
3. I added a prompt for the users first and last name.  That way if the journal is used
by multiple people, everyone know who wrote what.
4. I added a feature to the write function that allows the user to type DONE after hitting
enter that will exit the prompt.  Not intuitive, but it's there.
*/

using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");
        Console.WriteLine("Please enter your first and last name:");
        string name = Console.ReadLine();
        Prompts prompts = new Prompts();
        bool enablePrompts = true; // Default to enabled.

        Journal journal = new Journal(name);
        string dateText = DateTime.Now.ToShortDateString();

        while (true)
        {
            Menu menu = new Menu();
            menu.DisplayMenu();

            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int menuOption))
            {
                if (menuOption == 1)
                {
                    string newData;
                    if (enablePrompts)
                    {
                        string randomPrompt = prompts.GetRandomPrompt();
                        Console.WriteLine(randomPrompt);
                        Console.WriteLine("Enter 'DONE' to exit writing.");
                    }
                    newData = journal.GetUserJournalEntry(enablePrompts);
                    string combinedData = journal.CombineData(dateText, newData);
                }
                else if (menuOption == 2)
                {
                    if (journal.DataLoaded) // Check if data is loaded
                    {
                        journal.DisplayEntries();
                    }
                    else
                    {
                        Console.WriteLine("Data has not been loaded yet. Use option 3 to load data first.");
                    }
                }
                else if (menuOption == 3)
                {
                    journal.LoadDataFromFile("myFile.txt");
                    /*Journal loader = new LoadFile();
                    existingData = loader.LoadDataFromFile("myFile.txt");
                    dataLoaded = true;*/
                }
                else if (menuOption == 4)
                {
                    journal.SaveDataToFile("myFile.txt");
                    Console.WriteLine("Data saved successfully.");
                }
                else if (menuOption == 5)
                {
                    Console.WriteLine("Thank you for using the Journal Program.\nCome again soon.");
                    Environment.Exit(0);
                }
                else if (menuOption == 17)
                {
                    enablePrompts = !enablePrompts; // Toggle prompts on/off
                    Console.WriteLine("Prompts have been " + (enablePrompts ? "enabled." : "disabled."));
                }
                else
                {
                    Console.WriteLine("Invalid menu option");
                }
            }
        }
    }
}





