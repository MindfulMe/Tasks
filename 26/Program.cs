using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_26
{
    class Program
    {
        static void Converter(int n)
        {
            int temp = n % 2;
            if (n >= 2)            
                Converter(n/2);
            Console.Write(temp);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in binary");
            int n = Convert.ToInt32(Console.ReadLine());
            Converter(n);

            Console.ReadKey();
        }
    }
}
