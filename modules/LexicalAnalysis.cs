namespace MarkdownToHTML.modules
{
    public class Lexer
    {
        public static void Analyze(List<string> markdownFile)
        {
            for(int i = 0; i < markdownFile.Count; i++)
            {
                Console.WriteLine("Line " + i + " is:" + markdownFile[i]);
            }
        }
    }
}