//users contains all of the functions for adding and updating users.
// contains the data structure for users
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

public class Users
{
    public string EmployeeName { get; set; }
    public string Title { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool EmpStatus { get; set; }

    public string GetEmployeeName()
    {
        return EmployeeName;
    }
    public void SetEmployeeName(string newName)
    {
        EmployeeName = newName;
    }

    public string GetTitle()
    {
        return Title;
    }

public void SetTitle(string newTitle)
    {
        Title = newTitle;
    }

    public DateTime GetHireDate()
    {
        return HireDate;
    }

    public void SetHireDate(string newHireDate)
    {
        if (DateTime.TryParse(newHireDate, out DateTime result))
        {
            HireDate = result;
        }
        else
        {
            Console.WriteLine("Invalid date format for Hire Date.");
        }
    }

    public DateTime GetEndDate()
    {
        return EndDate;
    }

    public void SetEndDate(string newEndDate)
    {
        if (DateTime.TryParse(newEndDate, out DateTime result))
        {
            EndDate = result;
        }
        else
        {
            Console.WriteLine("Invalid date format for End Date.");
        }
    }

    public bool GetEmpStatus()
    {
        return EmpStatus;
    }

    public void SetEmpStatus(string newEmpStatus)
    {
        EmpStatus = false;
    }

    public Users()
    {
        // Default constructor needed for deserialization
    }

    // Constructor
    [JsonConstructor]
    public Users(string employeeName, string title, DateTime hireDate, DateTime endDate, bool empStatus)
    {
        EmployeeName = employeeName;
        Title = title;
        HireDate = hireDate;
        EndDate = endDate;
        EmpStatus = empStatus;
    }
    
    public static Users CreateNewUser()
    {
        Console.WriteLine("Enter the new employee's first name: ");
        string employeeName = Console.ReadLine();

        Console.WriteLine("What is the employee's title (mgr/emp)? ");
        string title = Console.ReadLine();
        title = title.ToUpper();

        // Check if the title is valid
        if (title != "MGR" && title != "EMP")
        {
            Console.WriteLine("Invalid title. Setting default to 'EMP'.");
            title = "EMP";
        }

        Console.WriteLine("Hire Date is set as today.");
        DateTime hireDate = DateTime.Now;
        DateTime endDate = DateTime.MinValue;
        bool EmpStatus = true;

        return new Users(employeeName, title, hireDate, endDate, EmpStatus);
    }

    public static List<Users> DisplayAllUsers()
    {
        List<Users> users = LoadJsonFile.LoadUsersFromJson();

        if (users != null && users.Any())
        {
            Console.WriteLine("All users:");
            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.GetEmployeeName()}; Title: {user.GetTitle()}, HireDate: {user.GetHireDate()}, Employee Status: {user.GetEmpStatus()}");
            }
        }
        else
        {
            Console.WriteLine("No users to display.");
        }
        return users;
    }

    
}
