using System;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the magic number.");
        //string num = Console.ReadLine();
        //int magic_number = int.Parse(num);
        
        // generate a random number between 1 and 100
        // new indicates a new random value while next defines the parameters.
        int magic_number = new Random().Next(1, 101);

        Console.WriteLine("What is your guess?");
        string guess = Console.ReadLine();
        int guess_int = int.Parse(guess);
        

        // While loop
        while (guess_int != magic_number)
        {
           if (guess_int < magic_number)
           {
            Console.WriteLine("Higher");
           }
           else 
           {
            Console.WriteLine("Lower");
           }
           //When condition is not met, keep looping and ask for a new guess.
            Console.WriteLine("Try again. What is your guess?");
            guess = Console.ReadLine();
            while (!int.TryParse(guess, out guess_int))
            {
                Console.WriteLine("Please enter a valid number.");
                guess = Console.ReadLine();
                //guess_int = int.Parse(guess);
            }
        } 
        //When condition is met, print the following.
        Console.WriteLine("You guessed it!");
    }
}