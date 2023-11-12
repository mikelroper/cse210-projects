public class Attributes
{
    public string ActivityName { get; private set; }
    public string ActivityDescription { get; private set; }
    public string ActivityGuidance { get; private set; } //private makes it so tha tyou can only use it in the instance of the class.

    public Attributes(string activityName, string activityDescription, string activityGuidance)
    {
        ActivityName = activityName;
        ActivityDescription = activityDescription;
        ActivityGuidance = activityGuidance;
    }
}

