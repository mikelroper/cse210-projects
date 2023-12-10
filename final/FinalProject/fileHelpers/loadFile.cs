using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class LoadJsonFile
{
    private const string FileName = @".\users.json";
    private const string FileNameTime = @".\time.json";
     public static List<Users> LoadUsersFromJson()
    {
        try
        {
            if (!File.Exists(FileName))
            {
                Console.WriteLine("The user file doesn't exist. Creating a new file.");
                File.Create(FileName).Close();
                return new List<Users>(); 
            }

            string json = File.ReadAllText(FileName);
            return JsonSerializer.Deserialize<List<Users>>(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading users: {ex.Message}");
            return null;
        }
    }

    public static void DisplayUsers(List<Users> users)
    {
        if (users != null && users.Any())
        {
            Console.WriteLine("Current users:");
            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.GetEmployeeName()}; Title: {user.GetTitle()}, HireDate: {user.GetHireDate()}, Employee Status: {user.GetEmpStatus()}");
            }
        }
        else
        {
            Console.WriteLine("No users to display.");
        }
    }

    public static string SelectUser(List<Users> users)
{
    if (users != null && users.Any())
    {
        Console.WriteLine("Current users:");
        for (int i = 0; i < users.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Name: {users[i].GetEmployeeName()}; Title: {users[i].GetTitle()}, HireDate: {users[i].GetHireDate()}, Employee Status: {users[i].GetEmpStatus()}");
        }

        Console.WriteLine("Select a user by entering the corresponding number:");
        int userInput;
        bool isValidInput = int.TryParse(Console.ReadLine(), out userInput);

        if (isValidInput && userInput >= 1 && userInput <= users.Count)
        {
            return users[userInput - 1].GetEmployeeName();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
    else
    {
        Console.WriteLine("No users to display.");
    }

    return null; // Return null if no valid user is selected
}

}
