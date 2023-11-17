using System.Collections.Generic;
using System.IO;
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

            // Save the updated list back to the JSON file
            string updatedJson = JsonSerializer.Serialize(loadedGoals, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("goals.json", updatedJson);

            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    }
}

