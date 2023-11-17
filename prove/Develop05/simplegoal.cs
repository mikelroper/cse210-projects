public class SimpleGoal : BaseGoal
{
    private string simple;

    //public SimpleGoal(){}

    /* public SimpleGoal(string goalName, string goalDescription, int goalPoints)
        : base(goalName, goalDescription, goalPoints)
    {
    } */


    public void CreateSimpleGoal()
    {
        _goalType = simple;
        Console.WriteLine("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of the goal: ");
        _goalDescription = Console.ReadLine();
        
        int goalPoints;
        do
        {
            Console.Write("Enter the number of points this goal is worth: ");
        } while (!int.TryParse(Console.ReadLine(), out goalPoints));
        _goalPoints = goalPoints;
        Console.WriteLine("");
    }
     /* public static void SaveSimpleGoal(List<SimpleGoal> loadedGoals, SimpleGoal simpleGoal)
    {
        // Add the new simple goal to the list
        loadedGoals.Add(simpleGoal);

        // Save the updated list back to the JSON file
        SaveGoalsToFile.SaveGoalsToJson(loadedGoals);

        Console.WriteLine("Simple goal created and saved. Press any key to return to the menu.");
    } */

}