using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathOperations
{
    class Program
    {
        static void Main()
        {
            int num1 = 3;
            int num2 = 5;
            int sum = num1 + num2;
            Console.WriteLine(sum);
            Console.ReadLine();

            int num3 = 3;
            int num4 = 5;
            int difference = num3 - num4;
            Console.WriteLine(difference);
            Console.ReadLine();

            int num5 = 3;
            int num6 = 5;
            int product = num5 * num6;
            Console.WriteLine(product);
            Console.ReadLine();

            int num7 = 3;
            int num8 = 3; //when divided by 5, the int answer is 0. To get an accurate answer, casting is needed
            int quotient = num7 / num8;
            Console.WriteLine(quotient);
            Console.ReadLine();

        }
    }
}
