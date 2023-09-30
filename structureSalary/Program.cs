using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structureSalary
{
    internal class Program
    {
        struct Employee
        {
            public string sName;
            public double dSalary;
        }
        static void Main(string[] args)
        {
            // declaring variables
            Employee e = new Employee();
            e.dSalary = 30000;

            Console.WriteLine("Enter your name: ");
            e.sName = Console.ReadLine();

            bool raise = GiveRaise(ref e);

            if (raise == true)
            {
                Console.WriteLine("Congrats on the raise! Your salary is now " + e.dSalary);
            }

        }

        static bool GiveRaise(ref Employee employee)
        {
            if (employee.sName == "Brevin")
            {
                employee.dSalary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}