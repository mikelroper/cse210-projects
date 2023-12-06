// update user entry.  
// save should be called automatically as part of the update.

class UpdateUser
{
    public static void UpdateUserEmployeeName(string employeeName, string newEmployeeName)
    {
        List<Users> users = LoadJsonFile.LoadUsersFromJson();

        if (users != null && users.Any())
        {
            Users userToUpdate = users.FirstOrDefault(u => u.GetEmployeeName() == employeeName);

            if (userToUpdate != null)
            {
                userToUpdate.SetEmployeeName(newEmployeeName); 

                // Save the updated user data back to the file
                SaveUserToFile.SaveUserToJson(users);

                Console.WriteLine($"User {employeeName}'s name updated to {newEmployeeName}.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
        else
        {
            Console.WriteLine("No users to update.");
        }
    }

    public static void UpdateUserTitle(string employeeName, string newTitle)
    {
        List<Users> users = LoadJsonFile.LoadUsersFromJson();

        if (users != null && users.Any())
        {
            Users userToUpdate = users.FirstOrDefault(u => u.GetEmployeeName() == employeeName);

            if (userToUpdate != null)
            {
                userToUpdate.SetTitle(newTitle.ToUpper()); // Update the title for the specific user

                // Save the updated user data back to the file
                SaveUserToFile.SaveUserToJson(users);

                Console.WriteLine($"User {employeeName}'s title updated to {newTitle}.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
        else
        {
            Console.WriteLine("No users to update.");
        }
    }

    public static void UpdateUserHireDate(string employeeName, string newHireDate)
    {
        List<Users> users = LoadJsonFile.LoadUsersFromJson();

        if (users != null && users.Any())
        {
            Users userToUpdate = users.FirstOrDefault(u => u.GetEmployeeName() == employeeName);

            if (userToUpdate != null)
            {
                userToUpdate.SetHireDate(newHireDate); 

                // Save the updated user data back to the file
                SaveUserToFile.SaveUserToJson(users);

                Console.WriteLine($"User {employeeName}'s hire date updated to {newHireDate}.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
        else
        {
            Console.WriteLine("No users to update.");
        }
    }
	
    public static void UpdateUserEndDate(string employeeName, string newEndDate)
    {
        List<Users> users = LoadJsonFile.LoadUsersFromJson();

        if (users != null && users.Any())
        {
            Users userToUpdate = users.FirstOrDefault(u => u.GetEmployeeName() == employeeName);

            if (userToUpdate != null)
            {
                userToUpdate.SetEndDate(newEndDate); 

                // Save the updated user data back to the file
                SaveUserToFile.SaveUserToJson(users);

                Console.WriteLine($"User {employeeName}'s hire date updated to {newEndDate}.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
        else
        {
            Console.WriteLine("No users to update.");
        }
    }

    public static void UpdateUserEmpStatus(string employeeName, string newEmpStatus)
    {
        List<Users> users = LoadJsonFile.LoadUsersFromJson();

        if (users != null && users.Any())
        {
            Users userToUpdate = users.FirstOrDefault(u => u.GetEmployeeName() == employeeName);

            if (userToUpdate != null)
            {
                userToUpdate.SetEmpStatus(newEmpStatus); 

                // Save the updated user data back to the file
                SaveUserToFile.SaveUserToJson(users);

                Console.WriteLine($"User {employeeName}'s hire date updated to {newEmpStatus}.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
        else
        {
            Console.WriteLine("No users to update.");
        }
    }

}

