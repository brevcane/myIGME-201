using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horton_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brevin Leo Horton");

            int intOne = 3;
            double doubleOne = 2.5;

            Console.WriteLine(intOne*doubleOne);

            for(int i = 0; i < intOne; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
