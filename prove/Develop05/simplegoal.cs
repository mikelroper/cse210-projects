public class SimpleGoal : BaseGoal
{
    

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

        SimpleGoal newSimpleGoal = new SimpleGoal();
        newSimpleGoal._goalType = "simple";
        BaseGoal.AddGoal(newSimpleGoal);
        SaveGoalsToFile.SaveGoalsToJson(BaseGoal.Goals);
    }
     
}