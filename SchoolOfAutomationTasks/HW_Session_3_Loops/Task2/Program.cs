namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing numbers from an array using foreach loop:");
            byte[] numbers = [1, 2, 3, 4, 5];

            foreach (byte number in numbers) 
            {
                Console.WriteLine(number);
            
            }
        }
    }
}
