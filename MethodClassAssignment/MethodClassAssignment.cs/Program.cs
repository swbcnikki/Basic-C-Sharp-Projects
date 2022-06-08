using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Void binary = new Void(); // instance. This is possible even
                                      // though main is static because the
                                      // class itself is not static

            
            binary.Brain(7, 6); //Call the method in the class, passing in two numbers.

            binary.Brain(num2: 7, num1: 6); //Call the method in the class, specifying the parameters by name.

            Console.ReadLine();

        }

    }
}
