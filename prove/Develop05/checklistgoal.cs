public class ChecklistGoal : BaseGoal
{
    //private string checklist;
    public void CreateChecklistGoal()  
    {
        _goalType = "checklist";
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
        
        int goalNumberOfTimes;
        do
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        } while (!int.TryParse(Console.ReadLine(), out goalNumberOfTimes));
        _goalNumberOfTimes = goalNumberOfTimes;
        Console.WriteLine("");
        
        int goalBonusValue;
        do
        {
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        } while (!int.TryParse(Console.ReadLine(), out goalBonusValue));
        _goalBonusValue = goalBonusValue;
        Console.WriteLine("");

        Console.WriteLine($"You have {_totalPoints}.");

        ChecklistGoal newChecklistGoal = new ChecklistGoal();
        newChecklistGoal._goalType = "Checklist";
        BaseGoal.AddGoal(newChecklistGoal);
        SaveGoalsToFile.SaveGoalsToJson(BaseGoal.Goals);
    }
    
}
