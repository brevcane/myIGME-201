using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadFormulaPE8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Index counters for x and y
            int counterY = 0;
            int counterX = 0;

            // New "quad" array used to store x y and z values
            double[,,] quad = new double[20, 30, 3];

            // for loop used to create values for x y and z
            for(double x = -1; x <= 1; x += 0.1, counterX++)
            {
                for(double y = 1; y <= 4; y += 0.1, counterY++)
                {
                    double z = (3*(Math.Pow(y, 2)) + (2*x) - 1);
                    quad[counterX, counterY, 0] = x;
                    quad[counterX, counterY, 1] = y;
                    quad[counterX, counterY, 2] = z;
                }
                
            }
        }
    }
}
