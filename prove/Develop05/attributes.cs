public class Attributes : BaseGoal
{
    /* public string GoalType { get; private set; }
    public string GoalName { get; private set; }
    public string GoalDescription { get; private set; }
    public int GoalPoints { get; private set; } //private makes it so tha tyou can only use it in the instance of the class.
    public int TotalPoints { get; private set; } */

    public Attributes(string goalType, string goalName, string goalDescription, int goalPoints, int totalPoints)
        : base(goalType, goalName, goalDescription, goalPoints, totalPoints)
    {
        GoalType = _goalType;
        GoalName = _goalName;
        GoalDescription = _goalDescription;
        GoalPoints = _goalPoints;
        TotalPoints = _totalPoints;
        //TotalPoints = totalPoints;  // this should be the total number of points and saved in the file. I think it belongs in another spot
    }

    

}

