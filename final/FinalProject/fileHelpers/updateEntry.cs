// update user entry.  
// save should be called automatically as part of the update.

class RecordEvent
{
    /* public List<BaseGoal> LoadedGoals { get; private set; }


    public RecordEvent()
    {
        var attributesList = LoadGoalsFromFile.LoadGoalsFromJson();
        LoadedGoals = LoadGoalsFromFile.ConvertAttributesToBaseGoals(attributesList);
        if (LoadedGoals == null)
        {
            LoadedGoals = new List<BaseGoal>();
        }
    }

    public void DisplayGoals()
    {
        if (LoadedGoals != null && LoadedGoals.Any())
        {
            Console.WriteLine("List of Goals:");
            for (int i = 0; i < LoadedGoals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Goal Name: {LoadedGoals[i].GoalName}, Description: {LoadedGoals[i].GoalDescription}, Points: {LoadedGoals[i].GoalPoints}, TotalPoints: {LoadedGoals[i].TotalPoints}");
            }
        }
        else
        {
            Console.WriteLine("No goals to display.");
        }
    }

    public void UpdateAndSaveGoals()
    {
        // Logic to update goals and assign points
        // Display the goals with their assigned numbers
        DisplayGoals();

        // Prompt the user to enter the number of the goal to update points
        Console.WriteLine("Enter the number of the goal you completed: ");
        int selectedGoalNumber;
        while (!int.TryParse(Console.ReadLine(), out selectedGoalNumber) || selectedGoalNumber < 1 || selectedGoalNumber > LoadedGoals.Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
            Console.WriteLine("Enter the number of the goal you completed: ");
        }

        var goalToUpdate = LoadedGoals[selectedGoalNumber - 1]; // Adjust index
        // Set totalPoints to goalPoints initially
        int goalPoints = goalToUpdate.GoalPoints;
        goalToUpdate.UpdateTotalPoints(goalPoints);

        // Show the initial totalPoints before updating
        int totalPointsAcrossGoals = LoadedGoals.Sum(goal => goal.TotalPoints);
        Console.WriteLine($"Total Points: {totalPointsAcrossGoals}");;

        // Prompt for additional points and update totalPoints
        Console.WriteLine($"Enter the additional points for {goalToUpdate.GoalName}: ");
        if (int.TryParse(Console.ReadLine(), out int additionalPoints))
        {
            goalToUpdate.UpdateTotalPoints(additionalPoints);
            SaveGoalsToFile.SaveGoalsToJson(LoadedGoals);
            Console.WriteLine($"Points updated for {goalToUpdate.GoalName}. Goals saved successfully.");
        }
        else
        {
            Console.WriteLine("Invalid input for points.");
        }
    }
    public void RecordEventAndUpdateGoals()
    {
        DisplayGoals(); // Show the list of goals
        
        // Get the user's choice of which goal to update based on the event
        Console.WriteLine("Enter the number of the goal you completed: ");
        int selectedGoalNumber;

        // Input validation to ensure a valid goal number is entered
        while (!int.TryParse(Console.ReadLine(), out selectedGoalNumber) || selectedGoalNumber < 1 || selectedGoalNumber > LoadedGoals.Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
            Console.WriteLine("Enter the number of the goal you completed: ");
        }

        // Get the selected goal from the loaded goals list
        var goalToUpdate = LoadedGoals[selectedGoalNumber - 1]; // Adjust index

        // Logic to record the event and update the goal properties (e.g., points)
        Console.WriteLine($"Enter the points achieved for {goalToUpdate.GoalName}: ");
        if (int.TryParse(Console.ReadLine(), out int pointsAchieved))
        {
            // Update the goal's points with the recorded event points
            goalToUpdate.UpdateTotalPoints(pointsAchieved);

            // Save the updated goals to the JSON file
            SaveGoalsToFile.SaveGoalsToJson(LoadedGoals);

            Console.WriteLine($"Points updated for {goalToUpdate.GoalName}. Goals saved successfully.");
        }
        else
        {
            Console.WriteLine("Invalid input for points.");
        }
    } */
}
