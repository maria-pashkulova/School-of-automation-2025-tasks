namespace CountriesAndCapitals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals["Bulgaria"] = "Sofia"; // Add more entries
            capitals["France"] = "Paris";
            capitals["Germany"] = "Berlin";
            capitals["Italy"] = "Rome";
            capitals["Spain"] = "Madrid";
            capitals["United Kingdom"] = "London";

            Console.WriteLine($"The capital city of Bulgaria is: {capitals["Bulgaria"]}");

            Console.WriteLine("All countries and capitals in the list:");
            foreach (var entry in capitals)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }

        }
    }
}
