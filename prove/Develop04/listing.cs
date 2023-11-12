using System;
using System.Diagnostics;
using System.Collections.Generic;
public class Listings : BaseActivity
{
    private readonly string[] listingsPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes"
    };

    private Behaviors listingsBehaviors;

    public Listings(string activityName, string activityDescription, string activityGuidance)
        : base(activityName, activityDescription, activityGuidance)
    {
        listingsBehaviors = new Behaviors();
    }

    public void StartListingActivity()
    {
        DisplayCommonStartingMessage(); // Display the standard starting message

    // Customize the description for the listings activity
    Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

    // Prompt user for the number of seconds for the listings activity
    Console.WriteLine("Please specify the duration for this listings exercise.");
    _duration = GetDurationFromUser();

    // Create a timer to automatically stop the activity
    System.Timers.Timer timer = new System.Timers.Timer(_duration * 1000);
    timer.Elapsed += (sender, e) => StopListingsActivity(timer);
    timer.AutoReset = false;
    timer.Start();

    // Start the stopwatch to measure the total elapsed time
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    // Perform the listings exercise
    PerformListingsExercise();

    // Stop the stopwatch
    stopwatch.Stop();

    // Calculate the elapsed time in seconds
    double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
    Console.WriteLine($"Elapsed time: {elapsedSeconds:F2} seconds");
    // Conclude the activity with the standard finishing message
    DisplayCommonFinishingMessage();

    
    }

    private void StopListingsActivity(System.Timers.Timer timer)
    {
        timer.Stop();
        Console.WriteLine("Time's up!");
        DisplayCommonFinishingMessage();
    }

    private void PerformListingsExercise()
    {
        Console.WriteLine("Let's begin the listings exercise!");

        int itemCounter = 0;

        for (int i = 0; i < _duration;)
        {
            string randomPrompt = listingsPrompts[new Random().Next(listingsPrompts.Length)];

            Console.WriteLine(randomPrompt);
            listingsBehaviors.Countdown(5); // Countdown for 5 seconds to begin thinking about the prompt
            Console.WriteLine("Go!");
            
            itemCounter += ListItemsUntilExit();

            i += 5; // Increment by the countdown time

            if (i >= _duration)
                break;
        }

        Console.WriteLine($"You listed {itemCounter} items.");
    }

    private int ListItemsUntilExit()
    {
        int itemCounter = 0;
        string input;

        while (true)
        {
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            itemCounter++;
        }

        return itemCounter;
    }
}
