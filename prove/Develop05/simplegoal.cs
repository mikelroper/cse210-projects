public class SimpleGoal : BaseGoal
{
    private string simple;

    /* public SimpleGoal(string goalType, string goalName, string goalDescription, int goalPoints, int totalPoints) : base(goalType, goalName, goalDescription, goalPoints, totalPoints)
    {
    } */


    public void CreateSimpleGoal()
    {
        _goalType = "simple";
        Console.WriteLine("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of the goal: ");
        _goalDescription = Console.ReadLine();
        
        int goalPoints;
        do
        {
            Console.Write("Enter the number of points this goal is worth: ");
        } while (!int.TryParse(Console.ReadLine(), out goalPoints));
        GoalPoints = goalPoints;
        Console.WriteLine("");
        TotalPoints = 0;
    }
     
}