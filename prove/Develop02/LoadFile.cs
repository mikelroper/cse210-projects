using System;
using System.IO;
using System.Text;

public class LoadFile
{
    public string LoadDataFromFile(string filename)
    {
        StringBuilder fileContents = new StringBuilder();

        try
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    // Append each line to the StringBuilder
                    fileContents.AppendLine(line);
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred while reading the file: {e.Message}");
        }

        return fileContents.ToString();
    }
}