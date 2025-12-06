namespace StudentsNamesAndScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Dictionary<string, int> studentScores = new Dictionary<string, int>();

            Console.WriteLine("Enter student names and scores in the format: name - score. Score must be a valid integer value!");
            Console.WriteLine("Type 'end' to finish.");

            while (true)
            {
                Console.Write("Student entry: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    break;
                }

                string[] parts = input.Split(" - ");

                if (parts.Length != 2)
                {
                    Console.WriteLine("Invalid format! Please use: name - score");
                    continue;
                }

                string name = parts[0];
                string scores = parts[1];

                if (!int.TryParse(scores, out int score))
                {
                    Console.WriteLine("Score must be a valid integer!");
                    continue;
                }

                // Add to dictionary
                studentScores[name] = score;
            }
            // Calculate average
            if (studentScores.Count == 0)
            {
                Console.WriteLine($"{Environment.NewLine}No student entries!");
            }
            else
            {

                //1. Iteration

                //int sum = 0;
                //foreach (var studentEntry in studentScores)
                //{
                //    sum += studentEntry.Value;
                //}

                //double average = (double)sum / studentScores.Count;


                //2. Using Language integrated query (LINQ) and lamba expression

                double average = studentScores.Average(s => s.Value);

                Console.WriteLine($"{Environment.NewLine}Average score: {average:F2}");
            }


        }
    }
}
