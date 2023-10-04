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
using System.Text;

class Program
{
    static bool enablePrompts = true;
    static string name = "";
    static string newData = "";
    static string existingData = "";
    static string combinedData = "";
    
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        bool dataLoaded = false; 

        Console.WriteLine("Welcome to the Journal Program");
        Console.WriteLine("Please enter your first and last name:");
        name = Console.ReadLine();
        Prompts prompts = new Prompts();

        while (true)
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
            
            //Console.Write("> ");
            
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int menuOption))
            {
                if (menuOption == 1)
                {
                    if (enablePrompts)
                    {
                        string randomPrompt = prompts.GetRandomPrompt();
                        Console.WriteLine(randomPrompt);
                    }
                    DateTime currentDateTime = DateTime.Now;
                    string dateTimeString = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss"); //convert time to string for concat

                    StringBuilder newDataBuilder = new StringBuilder();
                    newDataBuilder.AppendLine($"{name}: {dateTimeString}");

                    string line;
                    while ((line = Console.ReadLine()) != "DONE")
                    {
                        newDataBuilder.AppendLine(line);
                    }
                    newData = newDataBuilder.ToString();
                }
                else if (menuOption == 2)
                {
                    // Display function (no need to load here)
                    if (dataLoaded)
                    {
                        // Display data
                        Console.WriteLine(existingData);
                    }
                    else
                    {
                        Console.WriteLine("Data has not been loaded yet. Use option 3 to load data first.");
                    }
                }
                else if (menuOption == 3)
                {
                    // Load function (no display)
                    LoadFile loader = new LoadFile();
                    existingData = loader.LoadDataFromFile("myFile.txt");
                    dataLoaded = true; 
                }
                else if (menuOption == 4)
                {
                    combinedData = $"{name}: {dateText}\n{existingData}\n{newData}";
                    string saveFileName = "myFile.txt";  
                    SaveFile fileSaver = new SaveFile();
                    fileSaver.SaveDataToFile(saveFileName, combinedData);
                    Console.WriteLine("Data saved successfully.");
                }
                else if (menuOption == 5)
                {
                    Console.WriteLine("Thank you for using the Journal Program.\nCome again soon.");
                    Environment.Exit(0);
                }
                else if (menuOption == 17)
                {
                    enablePrompts = false;
                    Console.WriteLine("Prompts have been disabled.");
                }
                else
                {
                    Console.WriteLine("Invalid menu option");
                }
            }
        }
    }
}
