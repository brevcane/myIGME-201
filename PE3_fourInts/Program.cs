using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_fourInts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize a starting number
            int startInt = 1;


            for (int i = 0; i < 4; i++)
            {
                // Prompt the user for a number
                Console.Write("Hello! Please enter a number: ");

                // Read the number and store it into a variable
                string sNumber = Console.ReadLine();

                // Convert the entered number into an int
                try
                {
                    int number = Convert.ToInt32(sNumber);
                    //Start multiplying the starting number
                    startInt *= number;
                }
                catch
                {
                    Console.WriteLine("Please enter an integer.");
                }

                //Using a loop, repeat this process three more times
            }

            Console.WriteLine(startInt.ToString());
        }
    }
}
