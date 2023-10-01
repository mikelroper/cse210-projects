// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 

public class SaveFile
{
    public void SaveDataToFile(string fileName, string dataToSave)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // Write the user's data to the file
            outputFile.WriteLine(dataToSave);
        }
    }
}