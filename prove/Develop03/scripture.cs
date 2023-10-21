// this fucntion is for the scipture 1 verse or multiple.

public class Scripture
{
    private List<string> _scriptureList;
    private List<Word> memorizationList;
    // Track hidden words
    private List<int> hiddenIndices = new List<int>(); 
    //To track the currently displayed scripture.
    private int _scriptureIndex; 

    public Scripture()
    {
        _scriptureList = new List<string>
        {
            "To every thing there is a season, and a time to every purpose under the heaven: A time to be born, and a time to die; a time to plant, and a time to pluck up that which is planted; A time to kill, and a time to heal; a time to break down, and a time to build up; A time to weep, and a time to laugh; a time to mourn, and a time to dance;",
            "And it shall come to pass, that those who have dwindled in unbelief shall be smitten by the hand of the Gentiles.",
            "Behold I have told you before.",
            "O God, where art thou? And where is the pavilion that covereth thy hiding place."
        };

        Random rng = new Random();

        int randomScriptureIndex;

        do
        {
            randomScriptureIndex = rng.Next(_scriptureList.Count);
        } while (randomScriptureIndex == _scriptureIndex);

        // Update the scripture index
        _scriptureIndex = randomScriptureIndex;

        string randomScripture = _scriptureList[_scriptureIndex];

        // Retrieve the reference value for the current scripture
        string reference = Reference.Items[_scriptureIndex];

        memorizationList = randomScripture
            .Split(' ')
            .Select(word => new Word(word))
            .ToList();

        // Pass the random index to Program.cs
        Console.WriteLine($"{reference} - {randomScripture}");
        Console.WriteLine("Press Enter to continue or 'quit' to finish:");

        // A different variable name is needed here to avoid conflict.
        Random rng2 = new Random(); 
        int wordIndex = 0;
        int totalWords = memorizationList.Count;

        while (hiddenIndices.Count < totalWords)
        {
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            int randomIndex;
            do
            {
                randomIndex = rng2.Next(totalWords);
            } while (hiddenIndices.Contains(randomIndex));

            memorizationList[randomIndex].Hide();
            hiddenIndices.Add(randomIndex);

            // Join the reference value and the scripture string.
            Console.WriteLine($"{reference} - {string.Join(" ", memorizationList.Select(w => w.GetDisplayText()))}");

            wordIndex++;

            // Check if all words are hidden.  If yes, program exits.
            if (hiddenIndices.Count == totalWords)
            {
                Environment.Exit(0); // Terminate the application when complete
            }

        }
    }

    public void PrintScripture()
    {
        string reference = Reference.Items[_scriptureIndex]; 
        List<string> displayedWords = new List<string>();

        foreach (var word in memorizationList)
        {
            displayedWords.Add(word.GetDisplayText());
        }
        Console.WriteLine($"{reference} - {string.Join(" ", displayedWords)}");
    }

}









