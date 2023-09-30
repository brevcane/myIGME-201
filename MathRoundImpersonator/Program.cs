using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathRoundImpersonator
{
    
    internal class Program
    {
        // the definition of the round delegate function
        delegate double roundFunction(double value, int digits);

        static void Main(string[] args)
        {
            // Variable used to store the delegate function
            roundFunction roundImpersonator;

            // Setting my variable equal to my new function
            roundImpersonator = new roundFunction(round);
        }

        static double round(double value, int digits)
        {
            // Calling Math.Round to impersonate the function
            return Math.Round(value, digits);
        }
    }
}
