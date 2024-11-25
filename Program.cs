using System.Text;

class Program
{
    static void Main()
    {
        try
        {
            bool stillGoing = true;
            while (stillGoing)
            {
                Console.WriteLine("Welcome to the Markdown Conversion Tool, Please Make Selection:");
                Console.WriteLine("0 - Exit Program");
                Console.WriteLine("1 - Convert File");

                string? entry = Console.ReadLine();

                if (!string.IsNullOrEmpty(entry))
                {
                    switch (entry)
                    {
                        case "0": // Exit Program Case
                            stillGoing = false;
                            Console.WriteLine("Exiting Program...");
                            break;
                        case "1": // Convert File from Markdown to HTML Case
                            try
                            {
                                ConvertFile();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Selection, Please Try Again");
                            break;
                    }
                }
                Console.WriteLine("\n");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unhandled Error: " + ex.Message);
        }
    }

    static void ConvertFile()
    {
        string path = GetPath();

        List<string> markdownList = [];

        // Read and process the Markdown file line by line
        using (StreamReader reader = new(path))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                markdownList.Add(line);
            }
        }
        Console.WriteLine("Read File at " + path);
    }

    static string GetPath()
    {
        while (true)
        {
            Console.WriteLine("Enter the path to the Markdown File:");
            string? path = Console.ReadLine();
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                return path;
            }
            else
            {
                Console.WriteLine("Invalid file path or file not found.\n");
            }
        }
    }
}