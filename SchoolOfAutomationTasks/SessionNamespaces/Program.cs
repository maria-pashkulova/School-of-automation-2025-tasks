using SessionNamespaces.HomeworkUtilities;


namespace SessionNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables of different types and use keywords like const, var, and static.
            const string prompt = "Enter a message to print:";
            var author = "Maria";

            Console.Write(prompt);
            string userInput = Console.ReadLine();
            
            Printer.PrintMessage("You said: " + userInput);


            Printer.GetPrintedMessagesCount();
            
        }
    }
}
