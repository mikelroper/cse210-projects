using System.Text.Json;

class LoadGoalsFromFile
{
    public static List<Attributes> LoadGoalsFromJson()
    {
        try
        {
            if (File.Exists(@".\person.json"))
            {
                string json = File.ReadAllText(@".\person.json");
                return JsonSerializer.Deserialize<List<Attributes>>(json);
            }
            else
            {
                Console.WriteLine("No goals found in the JSON file.");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading goals: {ex.Message}");
            return null;
        }
    }
    public static void DisplayGoals(List<Attributes> goals)
    {
        if (goals != null && goals.Any())
        {
            Console.WriteLine("List of Goals:");
            foreach (var goal in goals)
            {
                Console.WriteLine($"Goal Name: {goal.GoalName}, Description: {goal.GoalDescription}, Points: {goal.GoalPoints}");
            }
        }
        else
        {
            Console.WriteLine("No goals to display.");
        }
    }

    // This section is to load recorded goals - or recorded events
    //need to sum them and extract the value point value of the goal, and multiply.






}