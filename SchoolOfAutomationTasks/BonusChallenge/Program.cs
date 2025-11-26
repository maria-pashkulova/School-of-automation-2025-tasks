namespace BonusChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            while (true)
            {
                Console.Write("Enter N (-1000 to 999): ");

                //Validate input: N must be an integer between - 1000 and 999

                if (int.TryParse(Console.ReadLine(), out n) && n >= -1000 && n <= 999)
                {
                    break;   // n is valid so we exit the while loop
                }

                Console.WriteLine("Invalid input! Please enter an integer between -1000 and 999.");
            }

            Console.WriteLine($"All positive even numbers between {n} and 999 are:");

            for (int i = n; i <= 999; i++)
            {
                if (i < 0)
                {
                    continue; //skip negative numbers
                }

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
