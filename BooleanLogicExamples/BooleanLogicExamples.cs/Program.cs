using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicExamples.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // && is and, || is or, == is equal to, != is not equal to, ^ is XOR operator
            Console.WriteLine(true && true && true || false); //can combine many
            Console.ReadLine();

            Console.WriteLine(true && false);
            Console.ReadLine();

            Console.WriteLine(true && true);
            Console.ReadLine();

            Console.WriteLine(false && false);
            Console.ReadLine();

            Console.WriteLine(true || false);
            Console.ReadLine();

            Console.WriteLine(true || true);
            Console.ReadLine();

            Console.WriteLine(false || false);
            Console.ReadLine();

            Console.WriteLine(true == false);
            Console.ReadLine();

            Console.WriteLine(true == true);
            Console.ReadLine();

            Console.WriteLine(false == false);
            Console.ReadLine();

            Console.WriteLine(true != false);
            Console.ReadLine();

            Console.WriteLine(true != true);
            Console.ReadLine();

            Console.WriteLine(false != false);
            Console.ReadLine();

            Console.WriteLine(true ^ false);
            Console.ReadLine();

            Console.WriteLine(true ^ true);
            Console.ReadLine();

            Console.WriteLine(false ^ false);
            Console.ReadLine();
        }
    }
}
