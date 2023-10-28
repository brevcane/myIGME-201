using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedList<(double, double, double), double> equationZ = new SortedList<(double, double, double), double>();
            // where the index key fields are string = country name and int = year

            for (double x = 0; x <= 4; x += 0.1 )
            {
                for (double y = -1; y <= 1; y += 0.1 )
                {
                    for (double w = -2; w <= 0; w += 0.2)
                    {
                        equationZ[(w, x, y)] = Math.Round((4 * (Math.Pow(y, 3)) + 2 * (Math.Pow(x, 2)) - 8 * w + 7),3);

                    }

                }
            }

        }
    }
}
