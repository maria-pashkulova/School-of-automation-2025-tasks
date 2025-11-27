namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;

            while (true)
            {
                Console.Write("Enter a number greater than 100: ");

                if (double.TryParse(Console.ReadLine(), out number) && number > 100)
                {
                    break;   // number is valid so we exit the while loop
                }

                Console.WriteLine("Invalid input! Please enter an number greater than 100!");
                
            }

            //print numbers from 1 to the provided number
            int i = 1;
            while (i <= number)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
