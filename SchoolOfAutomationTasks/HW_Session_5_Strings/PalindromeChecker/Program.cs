namespace PalindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "abba";
            string b = "abva";

            IsStringPalindrome(a);
            IsStringPalindrome(b);


        }

        // Function to check if a string is a palindrome
        static void IsStringPalindrome(string s)
        {
            int len = s.Length;

            // Iterate over the first half of the string
            for (int i = 0; i < len / 2; i++)
            {

                // If the characters at symmetric positions are
                // not equal
                if (s[i] != s[len - i - 1])
                {
                    Console.WriteLine($"'{s}' is not a palindrome");
                    return;
                }

            }

            // If all symmetric characters are equal
            // then it is palindrome
            Console.WriteLine($"'{s}' is a palindrome");
        }
    }
}
