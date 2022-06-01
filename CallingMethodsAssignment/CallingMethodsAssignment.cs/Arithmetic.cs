using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment.cs
{
    public class Arithmetic
    {
        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        public static int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public static int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
    }
}
