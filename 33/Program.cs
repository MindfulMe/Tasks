using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Sum("", N, 0, 0);
            Console.ReadKey();
        }
        static void Sum(string s, int N, int prev, int sum)
        {
            if (sum == N)
            {
                Console.WriteLine(s);
                return;
            }
            for (int i = prev+1; i <= N - sum; i++)
            {
                Sum(s + " " + i, N, i, sum + i);
            }


        }

    }
}
