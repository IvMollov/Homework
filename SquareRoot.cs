using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 12345;
            double squareRoot = Math.Sqrt(value);
            Console.WriteLine("Square root of " + value + " is " + squareRoot + ".");
        }
    }
}
