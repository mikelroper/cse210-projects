public class EternalGoal :BaseGoal
{
    

    public void CreateEternalGoal()
    {
        _goalType = "eternal";
        Console.WriteLine("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of the goal: ");
        _goalDescription = Console.ReadLine();

        //need to add goal type to each goal set as part of the json and add to goal.cs
        EternalGoal newEternalGoal = new EternalGoal();
        newEternalGoal._goalType = "Eternal";
        BaseGoal.AddGoal(newEternalGoal);
        SaveGoalsToFile.SaveGoalsToJson(BaseGoal.Goals);
    }
    

    
}