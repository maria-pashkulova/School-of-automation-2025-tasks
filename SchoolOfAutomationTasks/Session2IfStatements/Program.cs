using System.Threading.Tasks;

namespace Session2IfStatements

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 6: Ask the user for their age and print whether they are a minor or an adult.");
            AgeIdentifier.DefineMinorOrAdult();

            Console.WriteLine("\nTask 7: Ask for a student's grade and print a performance message using nested if statements.");
            SchoolPerformanceChecker.GiveGradeFeedback();

            Console.WriteLine("\nBonus challange 1: Create a login system that checks username and password using nested if statements.Print appropriate messages for: Correct username and password, Correct username but wrong password, Wrong username.");
            LoginSystem.CheckCredentials();

            Console.WriteLine("\nBonus challange 2: Vacation planner");
            VacationPlanner.DetermineVacationInfo();
        }
    }
}
