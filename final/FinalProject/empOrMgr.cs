// determine if user is manager or employee

class empOrMgr
{
public static string GetUserTitle(string username)
    {
        List<Users> users = LoadJsonFile.LoadUsersFromJson();

        if (users != null && users.Any())
        {
            var user = users.FirstOrDefault(u => u.GetEmployeeName() == username);
            if (user != null)
            {
                return user.GetTitle(); // Returns the title (manager/employee) of the user
            }
        }
        return null; // User not found or no users loaded
    }
}