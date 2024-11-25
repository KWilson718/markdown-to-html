class Program{
    static void Main(){

        // This While Loop acts like a menu, where one can select what they want to do. There will be more options implemented at a later date. 
        bool stillGoing = true;
        while(stillGoing) {
            Console.WriteLine("Welcome to the Markdown Conversion Tool, Please Make Selection:");
            Console.WriteLine("0 - Exit Program");
            Console.WriteLine("1 - Convert File");
            
            string? entry = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(entry)) {
                switch(entry){
                    case "0": // Exit Program Case
                        stillGoing = false;
                        Console.WriteLine("Exiting Program...");
                        break;
                    case "1": // Convert File from Markdown to HTML Case
                        ConvertFile();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection, Please Try Again");
                        break;
                }    
            }
        }
    }

    static void ConvertFile() {
        Console.WriteLine("Converting File");
    }
}

/*

Console.WriteLine("Enter the path to the Markdown File:");
string? path = Console.ReadLine();
if (!string.IsNullOrEmpty(path) && File.Exists(path)){
    string markdown = File.ReadAllText(path);
    Console.WriteLine("Markdown Content:\n" + markdown);
}
else{
    Console.WriteLine("Invalid file path or file not found.");
}

Console.WriteLine("Do You Wish To Continue?");

*/