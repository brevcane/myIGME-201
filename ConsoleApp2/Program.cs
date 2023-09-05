using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number with a decimal precision of 2.");
            string input = Console.ReadLine();
            double dInput = double.Parse(input);
            dInput += 55.0;
            Console.WriteLine(dInput);
        }
    }
}
