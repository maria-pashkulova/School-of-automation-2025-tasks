using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2IfStatements
{
    static class VacationPlanner
    {
        public static void DetermineVacationInfo()
        {
            double budget = 0;
            string season = "";
            string destination;
            string typeOfVacation;
            double amountSpent;

            while (true)
            {

                if (budget == 0)
                {
                    Console.Write("Enter your budget (10.00 - 5000.00): ");
                    string inputBudget = Console.ReadLine();

                    if (double.TryParse(inputBudget, out budget))
                    {
                        if (budget < 10.00 || budget > 5000.00)
                        {
                            Console.WriteLine("Budget must be between 10.00 and 5000.00.");
                            budget = 0; // reset to retry
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid budget value! Please enter a valid number.");
                    }
                }
                if (season == "")
                {
                    Console.Write("Enter the season (summer or winter): ");
                    season = Console.ReadLine().Trim().ToLower();

                    if (season != "summer" && season != "winter")
                    {
                        Console.WriteLine("Invalid season! Please enter 'summer' or 'winter'.");
                        season = ""; // reset to retry
                    }
                }

                if (budget != 0 && season != "")
                {
                    break;
                }

            }
            //budget -> destination
            //season -> how much of the budget will be spent (= price of the campsite or hotel, according to destination
            //summer -> campsite; winter -> hotel; europe-> summer & winter -> hotel
            
            destination = GetDestination(budget);
            (typeOfVacation, amountSpent) = CalculateVacation(season, budget, destination);
           

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfVacation} - {amountSpent:F2}");
        }

        private static string GetDestination(double budget)
        {
            if (budget <= 100) return "Bulgaria";
            if (budget <= 1000) return "Balkans";
            return "Europe";
        }

        private static (string typeOfVacation, double amountSpent) CalculateVacation(string season, double budget, string destination)
        {
            if (destination == "Europe")
            {
                return ("Hotel", budget * 0.90);
            }

            if (season == "summer")
            {
                return ("Camp", destination == "Bulgaria" ? budget * 0.30 : budget * 0.40);
            }
            else // winter
            {
                return ("Hotel", destination == "Bulgaria" ? budget * 0.70 : budget * 0.80);
            }
        }
      
    }
}
