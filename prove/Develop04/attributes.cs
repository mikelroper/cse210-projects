public class Attributes
{
    public string ActivityName { get; private set; }
    public string ActivityDescription { get; private set; }
    public string ActivityGuidance { get; private set; }

    public Attributes(string activityName, string activityDescription, string activityGuidance)
    {
        ActivityName = activityName;
        ActivityDescription = activityDescription;
        ActivityGuidance = activityGuidance;
    }
}

