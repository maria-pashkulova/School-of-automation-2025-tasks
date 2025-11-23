using System.Threading.Tasks;

namespace Session2IfStatements

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 6: Ask the user for their age and print whether they are a minor or an adult.");
            AgeIdentifier.DefineMinorOrAdult();

            Console.WriteLine("Task 7: Ask for a student's grade and print a performance message using nested if statements.");
            SchoolPerformanceChecker.GiveGradeFeedback();

        }
    }
}
