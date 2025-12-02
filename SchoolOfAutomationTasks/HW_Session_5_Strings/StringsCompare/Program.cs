namespace StringsCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Test";
            string b = "test";

            bool areEqual = string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Strings {a} and {b} are equal (case-insensitive): {areEqual}");
        }
    }
}
