using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimensionalArrayTest1
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

            // Index counters for x and y
            int counterY = 0;
            int counterX = 0;

            // Create an array used to store x, y, and z values
            double[,,] doubles = new double[20, 40, 3];

            // -1 <= y <= 1 in .1 increments
            // 0 <= x <= 4 in .1 increments
            // round x and y to 1 decimal and z tot 3 decimals

            // for loops used to create and store values for x, y, and z
            for (double x = 0; x <= 4;  x += .1, counterX++)
            {
                for (double y = -1; y <= 1; y += .1, counterY++)
                {
                    double z = (4 * Math.Pow(y, 3) + 2 * Math.Pow(x, 2) - 8 * x + 7);

                    doubles[counterX, counterY, 0] = round(x, 1);
                    doubles[counterX, counterY, 1] = round(y, 1);
                    doubles[counterX, counterY, 2] = round(z, 3);
                }
            }
        }

        static double round(double value, int digits)
        {
            // Calling Math.Round to impersonate the function
            return Math.Round(value, digits);
        }
    }
}
