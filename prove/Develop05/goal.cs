public class BaseGoal
{
    private Attributes attributes;
    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalNumberOfTimes;
    protected int _goalPoints;
    protected int _goalBonusValue;
    protected int _totalPoints;

    public BaseGoal(){}  //this means you can instantiate this with or without arguments.  which by calling this allows for arguments to be passed or not.


    public BaseGoal(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _totalPoints = 0;
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
}