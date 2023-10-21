/*
Extras:
1. Random Scripture picking.
The program will randomly pick a scripture from those included and display it.  
The refernce for the scripture matches the random scripture based on the index value.
There are comments in the code explaining some parts of it.
*/

using System;

class Program
{
    // A random scripture is identified using the random index value
    private static int randomIndexFromScripture; 

    public static void SetRandomIndex(int randomIndex)
    {
        randomIndexFromScripture = randomIndex;
    }

    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Console.Clear();
        string itemFromReference = Reference.Items[randomIndexFromScripture];
        Console.WriteLine(itemFromReference);

        while (true)
        {
            scripture.PrintScripture();
            Console.WriteLine("Press Enter to continue or 'quit' to finish:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            Console.Clear();
        }
        
    }
}
