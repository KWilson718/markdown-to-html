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

    // static string ConvertMarkdownLineToHtml(string markdownLine)
    // {
    //     // Simple Markdown-to-HTML conversion
    //     if (markdownLine.StartsWith("# "))
    //         return "<h1>" + markdownLine.Substring(2) + "</h1>";
    //     if (markdownLine.StartsWith("## "))
    //         return "<h2>" + markdownLine.Substring(3) + "</h2>";
    //     if (markdownLine.StartsWith("### "))
    //         return "<h3>" + markdownLine.Substring(4) + "</h3>";
    //     if (markdownLine.StartsWith("- "))
    //         return "<li>" + markdownLine.Substring(2) + "</li>";

    //     // Fallback to a paragraph
    //     return "<p>" + markdownLine + "</p>";
    // }

    // static void SaveHtmlToFile(string html)
    // {
    //     while (true)
    //     {
    //         Console.WriteLine("Enter the destination path to save the HTML file:");
    //         string? path = Console.ReadLine();

    //         if (!string.IsNullOrEmpty(path))
    //         {
    //             try
    //             {
    //                 File.WriteAllText(path, html);
    //                 Console.WriteLine("HTML file saved successfully.");
    //                 break;
    //             }
    //             catch (Exception ex)
    //             {
    //                 Console.WriteLine("Error saving file: " + ex.Message);
    //             }
    //         }
    //         else
    //         {
    //             Console.WriteLine("Invalid path. Please try again.");
    //         }
    //     }
    // }
}