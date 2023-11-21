public class BaseGoal
{
    protected Attributes attributes;
    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalNumberOfTimes;
    protected int _goalPoints;
    protected int _goalBonusValue;
    protected int _totalPoints;
    public static List<BaseGoal> Goals = new List<BaseGoal>();
    
    public static BaseGoal Create(string goalType, string goalName, string goalDescription, int goalPoints, int totalPoints)
    {
        BaseGoal newGoal = new BaseGoal();
        newGoal.GoalType = goalType;
        newGoal.GoalName = goalName;
        newGoal.GoalDescription = goalDescription;
        newGoal.GoalPoints = goalPoints;
        newGoal.TotalPoints = totalPoints;
        return newGoal;
    }
    
    public string GoalType
    {
        get { return _goalType; }
        set { _goalType = value; }
    }

    public string GoalName
    {
        get { return _goalName; }
        set { _goalName = value; }
    }

    public string GoalDescription
    {
        get { return _goalDescription; }
        set { _goalDescription = value; }
    }

    public int GoalNumberOfTimes
    {
        get { return _goalNumberOfTimes; }
        set { _goalNumberOfTimes = value; }
    }

    public int GoalPoints
    {
        get { return _goalPoints; }
        set { _goalPoints = value; }
    }

    public int GoalBonusValue
    {
        get { return _goalBonusValue; }
        set { _goalBonusValue = value; }
    }

    public int TotalPoints
    {
        get { return _totalPoints; }
        set { _totalPoints = value; }
    }

    public void UpdateTotalPoints(int additionalPoints)
    {
        _totalPoints += additionalPoints;
    }

    public static void AddGoal(BaseGoal goal)
    {
        Goals.Add(goal);
    }

}