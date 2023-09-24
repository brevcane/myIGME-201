using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readLine
{
    internal class Program
    {
        delegate string readDelegate();
        static string readLine()
        {
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            readDelegate ReadLine = readLine;
        }
    }
}
