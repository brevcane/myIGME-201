using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yesOrNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt the user for a string
            Console.WriteLine("Input a string: ");

            // store the string into a variable
            string input = Console.ReadLine().ToLower();

            // replace every instance of no with yes
            input = input.Replace("no", "yes");


            // not sure how to make it "case insensitive" without going through every possible case for yes, Yes, YEs, YES, YeS, yES, yEs, yeS, so for now I'll just convert to lower case and convert no to yes
            
            // writing out the new string
            Console.WriteLine("New string: " + input);
        }
    }
}
