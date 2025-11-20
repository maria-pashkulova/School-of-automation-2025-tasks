using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a custom namespace called HomeworkUtilities with a class Printer that prints a message.
namespace SessionNamespaces.HomeworkUtilities
{
   
    internal class Printer
    {
        private static int usageCount = 0;
        public static void PrintMessage(string message)
        {
            usageCount++;
            Console.WriteLine(message);
        }

        public static void GetPrintedMessagesCount()
        {
            Console.WriteLine($"Printed {usageCount} message(s) with class Printer");
        }
    }
}
