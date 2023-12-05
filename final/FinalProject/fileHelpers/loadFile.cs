using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class LoadJsonFile
{
    private const string FileName = @".\users.json";
     public static List<Users> LoadUsersFromJson()
    {
        try
        {
            if (!File.Exists(FileName))
            {
                Console.WriteLine("The user file doesn't exist. Creating a new file.");
                File.Create(FileName).Close();
                return new List<Users>(); // Return an empty list as there are no goals yet.
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


}
