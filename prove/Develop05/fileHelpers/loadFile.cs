using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class LoadGoalsFromFile
{
    public static List<Attributes> LoadGoalsFromJson()
    {
        try
        {
            if (File.Exists(@".\goals.json"))
            {
                string json = File.ReadAllText(@".\goals.json");
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
                Console.WriteLine($"Goal Type: {goal.GoalType}; Goal Name: {goal.GoalName}, Description: {goal.GoalDescription}, Points: {goal.GoalPoints}, TotalPoints: {goal.TotalPoints}");
            }
        }
        else
        {
            Console.WriteLine("No goals to display.");
        }
    }

    public static List<BaseGoal> ConvertAttributesToBaseGoals(List<Attributes> attributesList)
    {
        if (attributesList == null)
        {
            return new List<BaseGoal>();
        }

        return attributesList.Select(attr =>
            new BaseGoal(attr.GoalType, attr.GoalName, attr.GoalDescription, attr.GoalPoints, attr.TotalPoints)
        ).ToList();
    }
}
