//users contains all of the functions for adding and updating users.
// contains the data structure for users
using System;
using System.Collections.Generic;
using System.Linq;

class Users
{
    private string EmployeeName { get; set; }
    private string Title { get; set; }
    private DateTime HireDate { get; set; }
    private bool EmpStatus { get; set; }

    public string GetEmployeeName()
    {
        return EmployeeName;
    }

    public string GetTitle()
    {
        return Title;
    }

    public DateTime GetHireDate()
    {
        return HireDate;
    }

    public bool GetEmpStatus()
    {
        return EmpStatus;
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

        return new Users
        {
            EmployeeName = employeeName,
            Title = title,
            HireDate = hireDate,
            EmpStatus = true // The new employee should have an active status
        };
    }

    /* public static void DisplayUsers(List<Users> users) //this is not needed here as it should be part of the load file process.
    {
        if (users != null && users.Any())
        {
            Console.WriteLine("Current users:");
            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.EmployeeName}; Title: {user.Title}; Hire Date: {user.HireDate}; Status: {user.EmpStatus}");
            }
        }
        else
        {
            Console.WriteLine("There are no users to display.");
        }
    } */
}
