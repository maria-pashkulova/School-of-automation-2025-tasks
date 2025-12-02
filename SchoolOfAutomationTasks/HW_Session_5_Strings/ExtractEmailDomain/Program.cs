namespace ExtractEmailDomain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter valid email: ");
            string email = Console.ReadLine();

            string domain = ExtractDomain(email);
            if (!string.IsNullOrEmpty(domain))
            {
                Console.WriteLine($"Email addrress domain: {domain}");
            }
            else
            {
                Console.WriteLine("Invalid email format.");
            }
        }
        public static string ExtractDomain(string email)
        {
            int atIndex = email.IndexOf('@');
            if (atIndex == -1)
            {
                return "";
            }
            return email.Substring(atIndex + 1);
        }
    }
}
