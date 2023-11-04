public class Reflection : BaseActivity
{
    private readonly string[] reflectionPrompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Behaviors reflectionBehaviors;

    public Reflection(string activityName, string activityDescription, string activityGuidance)
        : base(activityName, activityDescription, activityGuidance)
    {
        reflectionBehaviors = new Behaviors();
    }

    public void StartReflectionActivity()
    {
        DisplayCommonStartingMessage(); // Display the standard starting message

        // Customize the description for the reflection activity
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        // Prompt user for the number of seconds for the reflection activity
        Console.WriteLine("Please specify the duration for this reflection exercise.");
        duration = GetDurationFromUser();

        // Perform the reflection exercise
        PerformReflectionExercise();

        // Conclude the activity with the standard finishing message
        DisplayCommonFinishingMessage();


        ///////////////////////////  add menu display code here?
    }

    private void PerformReflectionExercise()
    {
        Console.WriteLine("Let's begin the reflection exercise!");

        for (int i = 0; i < duration;)
        {
            string randomPrompt = reflectionPrompts[new Random().Next(reflectionPrompts.Length)];
            string randomQuestion = reflectionQuestions[new Random().Next(reflectionQuestions.Length)];

            Console.WriteLine(randomPrompt);
            reflectionBehaviors.PauseWithSpinner(4000); // Pause for 4 seconds with a spinner

            Console.WriteLine("Now, please reflect on the following question:");
            Console.WriteLine(randomQuestion);
            reflectionBehaviors.PauseWithSpinner(5000); // Pause for 5 seconds with a spinner

            i += 9; // Increment by the total pause time

            if (i >= duration)
                break;
        }
    }
}
