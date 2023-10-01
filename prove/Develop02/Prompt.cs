using System;
using System.Collections.Generic;
  
public class Prompts
{
    public List<string>  promptList;
    public Random random;

    public Prompts()
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
    }

    public string GetRandomPrompt()
    {
        // Generate a random index to select prompt
        int randomIndex = random.Next(0, promptList.Count);
        // Return the random prompt
        return promptList[randomIndex];
    }
}

