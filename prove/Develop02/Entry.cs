using System;
using System.Text;

public class Entry
{
    public static string UserJournalEntry(string name, bool enablePrompts)
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

        return newDataBuilder.ToString();
    }
}