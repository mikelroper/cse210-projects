using System.Text.Json;


class SaveGoalsToFile
{
    public static void SaveGoalsToJson(List<BaseGoal> loadedGoals)
    {
        try
        {
            if (loadedGoals == null)
            {
                loadedGoals = new List<BaseGoal>();
            }

            string fileName = "goals.json";

            // Check if the file exists
            if (!File.Exists(fileName))
            {
                // Create the file if it doesn't exist
                File.Create(fileName).Close();
            }

            // Serialize the goals to JSON
            string updatedJson = JsonSerializer.Serialize(loadedGoals, new JsonSerializerOptions { WriteIndented = true });

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