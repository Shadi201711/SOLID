// Abstractions for file reading and writing
public interface IFileReader
{
    string ReadFile(string filePath);
}

public interface IFileWriter
{
    void WriteFile(string filePath, string content);
}

// Concrete implementations
public class FileReader : IFileReader
{
    public string ReadFile(string filePath)
    {
        // Code to read file content
        return "File content";
    }
}

public class FileWriter : IFileWriter
{
    public void WriteFile(string filePath, string content)
    {
        // Code to write file content
    }
}

// FileProcessor using abstractions
public class FileProcessor
{
    private readonly IFileReader fileReader;
    private readonly IFileWriter fileWriter;

    public FileProcessor(IFileReader reader, IFileWriter writer)
    {
        fileReader = reader;
        fileWriter = writer;
    }

    public void ProcessFile(string inputFilePath, string outputFilePath)
    {
        string fileContent = fileReader.ReadFile(inputFilePath);
        // Process the file content
        fileWriter.WriteFile(outputFilePath, fileContent);
    }
}
