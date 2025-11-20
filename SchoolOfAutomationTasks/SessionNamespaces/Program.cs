using SessionNamespaces.HomeworkUtilities;


namespace SessionNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables of different types and use keywords like const, var, and static.
            const string prompt = "Enter a message to print: ";
            Console.Write(prompt);
            string userInput = Console.ReadLine();

            Console.Write("Enter your name: ");
            var author = Console.ReadLine();

            Printer.PrintMessage("You said: " + userInput);

            //Perform arithmetic and logical operations on two integers and print the results.
            byte x = 12;
            byte y = 5;
            
            int sum = x + y;
            int remainder = x % y;
            bool isGreater = x > y;

            Printer.PrintMessage("\nArithmetic and logical operations results for x = 12 and y = 5:");
            Printer.PrintMessage($"Sum:{sum}");
            Printer.PrintMessage($"Remainder:{sum}");
            Printer.PrintMessage($"x > y: {isGreater}");

            Printer.PrintMessage($"\nProgram executed by: {author}");
            Printer.GetPrintedMessagesCount();
            
        }
    }
}
