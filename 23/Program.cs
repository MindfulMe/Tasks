using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_23
{
    class Program
    {
        static void ConverterToBinary(int n)
        {
            int temp = n % 2;
            if (n >= 2)
                ConverterToBinary(n / 2);
            Console.Write(temp);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers in binary");

            string value1 = Console.ReadLine();
            byte number1 = 0;

            try
            {
                number1 = Convert.ToByte(value1, 2);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in the correct format for a base {1} byte value.", value1, 2);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of the Byte type.", value1);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("'{0}' is invalid in base {1}.", value1, 2);
            }


            string value2 = Console.ReadLine();
            byte number2 = 0;

            try
            {
                number2 = Convert.ToByte(value2, 2);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in the correct format for a base {1} byte value.", value2, 2);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of the Byte type.", value2);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("'{0}' is invalid in base {1}.", value2, 2);
            }


            int res = number1 * number2;
            ConverterToBinary(res);
            Console.ReadKey();

        }
    }
}
