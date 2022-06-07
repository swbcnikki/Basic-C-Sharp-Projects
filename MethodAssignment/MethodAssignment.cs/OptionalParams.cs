using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment.cs
{
    class OptionalParams
    {
        //Create a class. In that class, create a method that takes two integers as parameters. Make one of
        //them optional. Have the method do a math operation and return an integer result.
        public int Addition(int num1, int num2 = 4) // method with default param num2          
        {    
            int result = num1 + num2; // math operation with 1 param
            return result; // result 

        }

                  
        
        
    }
}
