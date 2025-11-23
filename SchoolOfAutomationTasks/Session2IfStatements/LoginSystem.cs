using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2IfStatements
{
    static class LoginSystem
    {
        const string correctUsername = "mpashkulova";
        const string correctPassword = "mpass";

        public static void CheckCredentials()
        {
           Console.Write("Enter username: ");
           string inputUsername = Console.ReadLine().Trim();
           Console.Write("Enter password: ");
           string inputPassword = Console.ReadLine().Trim();

            if (String.IsNullOrEmpty(inputUsername) || String.IsNullOrEmpty(inputPassword))
            {
                Console.WriteLine("Username and password can't be empty");
                return; //stop further checking if input is empty / null
            }

            if (inputUsername == correctUsername)
            {
                if (inputPassword == correctPassword)
                {
                    Console.WriteLine("Correct username and password");
                }
                else
                {
                    Console.WriteLine("Correct username but wrong password");
                }
            }
            else
            {
                Console.WriteLine("Wrong username");
            }

        }

    }
}
