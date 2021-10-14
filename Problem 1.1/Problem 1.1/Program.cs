using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1._1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //User name 
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            //User age 
            Console.WriteLine("Enter your age: ");
            string stringUserAge = Console.ReadLine();

            //Casting string to int
            int intUserAge = Int32.Parse(stringUserAge);

            if (intUserAge > 18)
            {
                Console.WriteLine("Hi " + userName + "! You qualify to " +
                    "apply for a car driver license.");
            }

            else if (intUserAge == 17) 
            {
                Console.WriteLine("Hi " + userName + "! You qualify to " +
                    "apply for a car learner license.");
            }
            else
            {
                Console.WriteLine("Hi " + userName + "! You do not qualify to " +
                    "apply for a car learner or driver license.");
            }
            Console.ReadLine();
        }
    }
}
