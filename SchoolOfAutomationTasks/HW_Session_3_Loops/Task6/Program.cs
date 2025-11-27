namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Enter a positive integer n: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }

            //prime number - a number greater than 1 that can only be divided by itself and 1 without remainders
            Console.WriteLine($"Prime numbers between 1 and {n}:");

            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static bool IsPrime(int n)
        {
            // Check divisibility from 2 up to n-1
            for (int i = 2; i < n; i++)
            {
                // if the number is divisible by i, then n is not a
                // prime number.
                if (n % i == 0)
                {
                    return false;
                }
            }
            // otherwise, n is prime number.
            return true;
        }
    }
}
