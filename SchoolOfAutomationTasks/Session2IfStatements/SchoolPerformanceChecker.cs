using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2IfStatements
{
    static class SchoolPerformanceChecker
    {
        public static void GiveGradeFeedback()
        {
            byte grade;

            while (true)
            {

                Console.Write("Enter your grade (2-6): ");

                try
                {
                    grade = byte.Parse(Console.ReadLine());

                    if(grade >=2 && grade <=6)
                    {
                        break; //valid grade
                    }
                    else
                    {
                        Console.WriteLine("Grade must be a number between 2 and 6!");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid grade! Please enter a valid grade (2-6)!");
                }
            }

            if (grade == 2)
            {
                Console.WriteLine("Poor!");
            } 
            else 
            {
                if (grade == 3)
                {
                    Console.WriteLine("Average!");
                }
                else
                {
                    if (grade == 4)
                    {
                        Console.WriteLine("Good!");
                    } 
                    else
                    {
                        if (grade == 5)
                        {
                            Console.WriteLine("Very good!");
                        }
                        else
                        {
                            Console.WriteLine("Excellent!");
                        }
                    }
                }
            }

        }
    }
}
