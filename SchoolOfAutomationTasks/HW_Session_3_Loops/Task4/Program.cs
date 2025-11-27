namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            do
            {
                Console.Write("Enter anything to continue, enter N to exit the program: ");
                userInput = Console.ReadLine().ToUpper();
            }
            while (userInput != "N");

            Console.WriteLine("Program ended.");
        }
    }
}
