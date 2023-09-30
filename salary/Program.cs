using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring variables
            string sName;
            double dSalary = 30000;
            Console.WriteLine("Enter your name: ");
            sName = Console.ReadLine();
            bool raise = GiveRaise(sName, ref dSalary);

            if(raise == true)
            {
                Console.WriteLine("Congrats on the raise! Your salary is now " + dSalary);
            }

        }

        static bool GiveRaise(string name, ref double salary)
        {
            if (name == "Brevin")
            {
                salary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
