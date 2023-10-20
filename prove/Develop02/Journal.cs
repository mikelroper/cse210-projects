using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Journal
{
    private string name;
    private List<string> journalEntries;
    private string existingData;
    private bool dataLoaded;

    public Journal(string name)
    {
        this.name = name;
        this.journalEntries = new List<string>();
        this.existingData = "";
    }

    public string GetUserJournalEntry(bool enablePrompts)
    {
        StringBuilder newDataBuilder = new StringBuilder();
        DateTime currentDateTime = DateTime.Now;
        string dateTimeString = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        newDataBuilder.AppendLine($"{name}: {dateTimeString}");

        string line;
        while ((line = Console.ReadLine()) != "DONE")
        {
            newDataBuilder.AppendLine(line);
        }

        string newEntry = newDataBuilder.ToString();
        journalEntries.Add(newEntry); // Add the new entry to the list.
        return newEntry;
    }

    // Load data from file.
    public void LoadDataFromFile(string filename)
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
                existingData = fileContents.ToString();
                dataLoaded = true; // Set dataLoaded to true when data is successfully loaded
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
    }

    // Save data to file
    public void SaveDataToFile(string filename)
    {
        StringBuilder combinedDataBuilder = new StringBuilder();

        foreach (var entry in journalEntries)
        {
            combinedDataBuilder.AppendLine(entry);
        }

        string combinedData = CombineData(DateTime.Now.ToShortDateString(), combinedDataBuilder.ToString());

        SaveToFile(filename, combinedData);
    }

    private void SaveToFile(string filename, string dataToSave)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Write the user's data to the file
            outputFile.WriteLine(dataToSave);
        }
    }

    public string CombineData(string dateText, string newData)
    {
        return $"{name}: {dateText}\n{existingData}\n{newData}";
    }


    public void DisplayEntries()
    {
        // Display both loaded data and new entries
        Console.WriteLine(existingData); // Display loaded data
        foreach (var entry in journalEntries)
        {
            Console.WriteLine(entry); // Display new entries
        }
    }

    public void DisplayData()
    {
        foreach (var entry in journalEntries)
        {
            Console.WriteLine(entry);
        }
    }

    public bool DataLoaded
    {
        get { return dataLoaded; }
    }
}

