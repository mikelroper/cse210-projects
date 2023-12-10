using System.Text.Json;


class SaveUserToFile
{
    public static void SaveUserToJson(List<Users> usersList)
    {
        try
        {
            List<Users> existingUsers = new List<Users>();

            string fileName = "users.json";

            // Check if the file exists
            if (File.Exists(fileName))
            {
                // Read existing data from users.json
                string existingData = File.ReadAllText(fileName);

                // Deserialize existing data to a list of Users objects
                existingUsers = JsonSerializer.Deserialize<List<Users>>(existingData);
            }

            if (usersList != null && usersList.Any())
            {
                // Append new users to the existing list
                existingUsers.AddRange(usersList);

                // Serialize the updated list to JSON
                string updatedJson = JsonSerializer.Serialize(existingUsers, new JsonSerializerOptions { WriteIndented = true });

                // Write the JSON to the file (overwrite existing content)
                File.WriteAllText(fileName, updatedJson);

                Console.WriteLine("Users appended successfully.");
            }
            else
            {
                Console.WriteLine("No new users to append.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while appending users: {ex.Message}");
        }
    }

    public static void SaveTimeToJson(List<Time.TimeLog> timeLogs)
    {
        try
        {
            List<Time.TimeLog> existingTimeLogs = new List<Time.TimeLog>();

            string fileName = "time.json";

            // Check if the file exists
            if (File.Exists(fileName))
            {
                // Read existing data from time.json
                string existingData = File.ReadAllText(fileName);

                // Deserialize existing data to a list of Time.TimeLog objects
                existingTimeLogs = JsonSerializer.Deserialize<List<Time.TimeLog>>(existingData);
            }

            if (timeLogs != null)
            {
                // Append new time logs to the existing list
                existingTimeLogs.AddRange(timeLogs);

                // Serialize the updated list to JSON
                string updatedJson = JsonSerializer.Serialize(existingTimeLogs, new JsonSerializerOptions { WriteIndented = true });

                // Write the JSON to the file (overwrite existing content)
                File.WriteAllText(fileName, updatedJson);

                Console.WriteLine("Time logs appended successfully.");
            }
            else
            {
                Console.WriteLine("No new time logs to append.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while appending time logs: {ex.Message}");
        }
    }
}