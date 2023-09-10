using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greaterThanTen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initializing var1 and var2
            int? var1 = null;
            int? var2 = null;

            // Creating a bool variable to allow for the usage of a while loop.
            bool truth = false;

            while (truth == false)
            {
                // Prompt the user to enter two numbers, but to make sure they don't enter two numbers that are greater than 10.
                Console.WriteLine("Input one number of any value, and another number less than 11.");

                // Prompt the user for the first number, then store the given number into a variable.
                Console.WriteLine("First number: ");
                var1 = int.Parse(Console.ReadLine());

                // Prompt the user for the second number, then store the given number into a variable.
                Console.WriteLine("Second number: ");
                var2 = int.Parse(Console.ReadLine());

                if(var1 > 10 && var2 > 10)
                {
                    System.Console.WriteLine("These numbers are both greater than 10.\n");
                } else
                {
                    truth = true;
                }
            }

            

            

        }
    }
}
