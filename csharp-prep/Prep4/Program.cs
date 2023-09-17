using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to stop): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            // add number to the list if it's not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // add the numbers together
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // the average
        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // max number
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number > current max, new max to variable
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}