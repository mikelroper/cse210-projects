using System;
using System.Diagnostics;
using System.Collections.Generic;

public class BaseActivity
{
    private Attributes attributes;
    protected Behaviors behaviors;
    protected int duration;
    private Stopwatch sw = new Stopwatch();
    private double lastFrame;

    public BaseActivity(string activityName, string activityDescription, string activityGuidance)
    {
        attributes = new Attributes(activityName, activityDescription, activityGuidance);
        behaviors = new Behaviors();
    }

    public void DisplayCommonStartingMessage()
    {
        Console.WriteLine($"Activity: {attributes.ActivityName}");
        Console.WriteLine(attributes.ActivityDescription);
        //duration = GetDurationFromUser(); // Set the duration field
        Console.WriteLine($"You have {duration} seconds for this activity.");
    }

    public int GetDurationFromUser()
    {
        int duration;
        Console.Write("Enter the duration in seconds: ");
        if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
        {
            return duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric value.");
            return GetDurationFromUser();
        }
    }

    public void StartTimer()
    {
        sw.Start();
    }

    public double GetDeltaTime()
    {
        TimeSpan ts = sw.Elapsed;
        double firstFrame = ts.TotalMilliseconds;
        double dt = firstFrame - lastFrame;
        lastFrame = ts.TotalMilliseconds;
        return dt;
    }

    public void StopTimer()
    {
        sw.Stop();
    }

    public void DisplayCommonFinishingMessage()
    {
        Console.WriteLine($"You've completed the {attributes.ActivityName} activity. Great job!");
        behaviors.Pause(1000);
        Console.Clear(); // Clear the screen
        Console.WriteLine("Activity completed. Returning to the menu.");
        Program.DisplayMenu();
    }
}

