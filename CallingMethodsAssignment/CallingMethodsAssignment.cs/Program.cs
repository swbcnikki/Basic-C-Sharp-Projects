using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            int sum = Arithmetic.Add(10, 5);
            Console.WriteLine("The sum is " + sum);
            
            int difference = Arithmetic.Subtract(10, 5);
            Console.WriteLine("The difference is " + difference);
            
            int product = Arithmetic.Multiply (10, 5);
            Console.WriteLine("The product is " + product);
            
            int quotient = Arithmetic.Divide (10, 5);
            Console.WriteLine("The quotient is " + quotient);
            Console.ReadLine();
        }
               
    }
}
