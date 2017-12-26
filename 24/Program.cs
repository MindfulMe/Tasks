using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a dividable");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a divisor");
            uint b = UInt32.Parse(Console.ReadLine());

            double res1 = a % b;
            double res2 = (a - res1)/b;
            Console.WriteLine("Even part of the number {0} by {1} = {2}", a, b, res2);
            Console.WriteLine("Remnant from the dividing {0} by {1} = {2}", a, b, res1);
            Console.ReadKey();

        }
    }
}
