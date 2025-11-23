using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2IfStatements
{
    static class AgeIdentifier
    {
        public static void DefineMinorOrAdult()
        {
            byte age;

            while (true)
            {

                Console.Write("Enter your age: ");

                try
                {
                    age = byte.Parse(Console.ReadLine());
                    break;

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid age! Please enter a non-negative valid number!");
                }
            }

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else
            {
                Console.WriteLine("You are an adult.");
            }
        }
        


    }
}
