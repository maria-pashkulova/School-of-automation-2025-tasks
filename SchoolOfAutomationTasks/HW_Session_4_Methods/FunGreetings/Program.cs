using System.Xml.Linq;

namespace FunGreetings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine(MagicGreeting(userName));
        }

        static string MagicGreeting(string userName)
        {
            string[] greetings =
                {
                    $"Welcome, mighty {userName}!",
                    $"Greetings, traveler {userName}!",
                    $"Behold, the legendary {userName} has arrived!"
                };

            // Pick a random greeting
            Random rnd = new Random();
            int greetingIndex = rnd.Next(greetings.Length); //maxValue is exclusive

            return greetings[greetingIndex];
        }
    }
}
