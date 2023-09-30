using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            // int nY, syntax error, missing semicolon
            int nY;
            int nAnswer;

            // Console.WriteLine(This program calculates x ^ y.);, syntax error, missing quotation marks
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                // Console.ReadLine();, runtime error, never set sNumber = Console.ReadLine();
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
                // } while (int.TryParse(sNumber, out nX));, logical, the loop is setup to run as long as nX can be 
            } while (!int.TryParse(sNumber,out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            // Console.WriteLine("{nX}^{nY} = {nAnswer}"); syntax error, needs a $ at the front for string interpolation, otherwise it will just write "{nX}^{nY} = {nAnswer}"
            Console.WriteLine($"{nX}^{nY} = {nAnswer}");
        }


        // int Power(int nBase, int nExponent) logical, missing the static modifier.
        static int Power(int nBase, int nExponent)
        {
            // int returnVal = 0;
            // int nextVal = 0;
            // syntax, unnecessary to set these equal to 0
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                // returnVal = 0; logical, when x^0 it should always equal 1
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                // nextVal = Power(nBase, nExponent + 1); logical, by setting nExponent to nExponent + 1 I think you would get an infinite loop.
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            // returnVal; syntax, return the value
            return returnVal;
        }
    }
}

