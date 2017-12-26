using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in binary");
            string value = Console.ReadLine();
            byte number = 0;
            try
            {
                number = Convert.ToByte(value, 2);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in the correct format for a base {1} byte value.", value, 2);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of the Byte type.", value);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("'{0}' is invalid in base {1}.", value, 2);
            }
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
