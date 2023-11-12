using System.Diagnostics;

public class Breathing : BaseActivity
{
    private Behaviors breathingBehaviors;
    private Stopwatch breathingStopwatch;

    public Breathing(string activityName, string activityDescription, string activityGuidance)
        : base(activityName, activityDescription, activityGuidance)
    {
        breathingBehaviors = new Behaviors();
        breathingStopwatch = new Stopwatch();
    }

    public void StartBreathingActivity()
    {
        DisplayCommonStartingMessage(); // Display the standard starting message

        // Customize the description for the breathing activity
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        // Prompt the user for the number of seconds for the breathing activity
        Console.WriteLine("Please specify the duration for this breathing exercise.");
        _duration = GetDurationFromUser();

        // Start the stopwatch when the breathing activity begins
        breathingStopwatch.Start();
        Console.WriteLine("Let's begin the breathing exercise!");

        // Perform the breathing exercise
        while ((breathingStopwatch.ElapsedMilliseconds / 1000) < _duration) {
        //Console.WriteLine((breathingStopwatch.ElapsedMilliseconds / 1000).ToString()); //error checking
        PerformBreathingExercise();
        }

        // Stop the stopwatch when the breathing activity is complete
        breathingStopwatch.Stop();
        // Conclude the activity with the standard finishing message
        DisplayCommonFinishingMessage();
    }

    private void PerformBreathingExercise()
    {
        
                
            Console.WriteLine("Breathe in...");
            breathingBehaviors.Countdown(4); // Call the Countdown method on the breathingBehaviors instance
            Console.WriteLine("Breathe out...");
            breathingBehaviors.Countdown(4); // Call the Countdown method on the breathingBehaviors instance
        
    }
}
