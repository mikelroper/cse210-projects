using System;
using System.Collections.Generic;
  
public class Prompts
{
    public List<string>  promptList;
    public Random random;
    public bool enablePrompts; // Add a boolean variable to enable/disable prompts
    //public string noPrompt = "No prompt wanted.";
    public Prompts(bool enablePrompts = true)
    {
        promptList = new List<string>
        {
            "What was one good thing that happened to you today?",
            "What are you most grateful for?",
            "What is something uncommon that happened to you today?",
            "What is one thing you felt you should work on?",
            "What was something kind you noticed someone do?",
            "Who did you show kindness to?"
        };
        random = new Random();
        this.enablePrompts = enablePrompts; // Initialize the enablePrompts variable
    }

    public string GetRandomPrompt()
    {
        if (enablePrompts)
        {
            // Generate a random index to select prompt
            int randomIndex = random.Next(0, promptList.Count);
            // Return the random prompt
            return promptList[randomIndex];
        }
        else
        {
            string noPrompt = "No prompt wanted.";
            return noPrompt;
        }
    }
}

