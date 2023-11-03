using System;
using System.Threading;

public class Behaviors
{
    public void Pause(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i}");
            Pause(1000); // Pause for 1 second
        }
    }
    public void PauseWithSpinner(int milliseconds)
    {
        int spinnerDelay = 500; // Delay for each "frame" of the spinner
        int numFrames = milliseconds / spinnerDelay;
        string[] spinnerFrames = { "/", "-", "\\", "|" }; // Spinner characters

        for (int i = 0; i < numFrames; i++)
        {
            Console.Write($"\r{spinnerFrames[i % 4]}"); // Use carriage return to overwrite the spinner
            Thread.Sleep(spinnerDelay);
        }
        
        Console.WriteLine(); // Print a newline character to clear the spinner
    }
}
