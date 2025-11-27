namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing a multiplication table from 1 to 5 using nested for loops: " + Environment.NewLine);
            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    //{0,-12} left-align in a 12-character field ->
                    //used to print expression with 12-character spacing between 'columns'
                    
                    Console.Write("{0,-12}",$"{i} * {j} = {i * j}");
                }
                Console.WriteLine(); // move to the next row after finishingthe inner loop
            }
        }
    }
}
