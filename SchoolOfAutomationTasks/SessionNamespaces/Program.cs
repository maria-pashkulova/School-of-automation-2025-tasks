using SessionNamespaces.HomeworkUtilities;
using SessionNamespaces.SimpleCalculator;
using System.Reflection;


namespace SessionNamespaces
{
    //class is accessible only within its own assembly (current project)
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
            Printer.PrintMessage($"Remainder:{remainder}");
            Printer.PrintMessage($"x > y: {isGreater}");

            // Bonus challange: calculator
            var calc = new SimpleCalculator.Calculator();
            Printer.PrintMessage("\nCalculator operations results:");
            Printer.PrintMessage($"Calc 7 + 3: {calc.Add(7, 3)}");
            Printer.PrintMessage($"Calc 14 - 2: {calc.Subtract(14, 2)}");
            Printer.PrintMessage($"Calc 6 * 4: {calc.Multiply(6, 4)}");
            Printer.PrintMessage($"Calc 12 / 5: {calc.Divide(12, 5):F2}");

            Printer.PrintMessage($"\nProgram executed by: {author}");
            Printer.GetPrintedMessagesCount();
            
        }
    }
}
