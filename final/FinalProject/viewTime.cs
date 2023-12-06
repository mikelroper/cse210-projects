
class ViewTime
{
    public static void ViewTimeEmp(string employeeName)
    {
        List<Users> users = LoadJsonFile.LoadUsersFromJson();

        if (users != null && users.Any())
        {
            var user = users.FirstOrDefault(u => u.GetEmployeeName() == employeeName && u.GetTitle() == "EMP");
            if (user != null)
            {
                Console.WriteLine($"Name: {user.GetEmployeeName()}; Title: {user.GetTitle()}, HireDate: {user.GetHireDate()}, Employee Status: {user.GetEmpStatus()}");
            }
            else
            {
                Console.WriteLine("No matching employee found.");
            }
        }
        else
        {
            Console.WriteLine("No users to display.");
        }
    }

    public static void ViewTimeMGR()
    {
        List<Users> users = LoadJsonFile.LoadUsersFromJson();

        if (users != null && users.Any())
        {
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
