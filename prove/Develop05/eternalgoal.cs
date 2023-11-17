public class EternalGoal :BaseGoal
{
    private string eternal;
    /* public EternalGoal(string goalName, string goalDescription, int goalPoints)
        : base(goalName, goalDescription, goalPoints)
    {
    } */

    public void CreateEternalGoal()
    {
        _goalType = eternal;
        Console.WriteLine("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of the goal: ");
        _goalDescription = Console.ReadLine();

        //need to add goal type to each goal set as part of the json and add to goal.cs
    }


}