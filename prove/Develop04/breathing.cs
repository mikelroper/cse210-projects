public class Breathing : BaseActivity
{
    private Behaviors breathingBehaviors;

    public Breathing(string activityName, string activityDescription, string activityGuidance)
        : base(activityName, activityDescription, activityGuidance)
    {
        breathingBehaviors = new Behaviors();
    }

    public void StartBreathingActivity()
    {
        DisplayCommonStartingMessage(); // Display the standard starting message

        // Customize the description for the breathing activity
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        // Prompt the user for the number of seconds for the breathing activity
        Console.WriteLine("Please specify the duration for this breathing exercise.");
        duration = GetDurationFromUser();

        // Perform the breathing exercise
        PerformBreathingExercise();

        // Conclude the activity with the standard finishing message
        DisplayCommonFinishingMessage();
    }

    private void PerformBreathingExercise()
    {
        Console.WriteLine("Let's begin the breathing exercise!");
        for (int i = 0; i < duration; i += 4) // Increment by 4 seconds
        {
            Console.WriteLine("Breathe in...");
            breathingBehaviors.Countdown(4); // Call the Countdown method on the breathingBehaviors instance
            Console.WriteLine("Breathe out...");
            breathingBehaviors.Countdown(4); // Call the Countdown method on the breathingBehaviors instance
        }
    }
}
