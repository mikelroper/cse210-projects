using System.Text.Json;


class SaveUserToFile
{
    public static void SaveUserToJson(List<Users> user)
    {
        try
        {
            if (user == null)
            {
                user = new List<Users>();
            }

            string fileName = "users.json";

            // Check if the file exists
            if (!File.Exists(fileName))
            {
                // Create the file if it doesn't exist
                File.Create(fileName).Close();
            }

            // Serialize the user to JSON
            string updatedJson = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });

            // Write the JSON to the file (overwrite existing content)
            File.WriteAllText(fileName, updatedJson);

            Console.WriteLine("User saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving user: {ex.Message}");
        }
    } 

    public static void SaveTimeToJson(List<Users> user)
    {
        try
        {
            if (user == null)
            {
                user = new List<Users>();
            }

            string fileName = "time.json";

            // Check if the file exists
            if (!File.Exists(fileName))
            {
                // Create the file if it doesn't exist
                File.Create(fileName).Close();
            }

            // Serialize the goals to JSON
            string updatedJson = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });

            // Write the JSON to the file (overwrite existing content)
            File.WriteAllText(fileName, updatedJson);

            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    } 
}