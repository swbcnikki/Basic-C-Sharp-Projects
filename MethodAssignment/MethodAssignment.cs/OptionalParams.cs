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
        public int Addition(int num1) // method with 1 param
        {           
            Addition(num1, null); // null allows for 1 param to be passed
            int result = num1 + num1; // math operation with 1 param
            return result; // result 

        }

        public int Addition(int num1, int[] moreNums) // method with 1 required and 1 optional param
        {
            int result = num1 + num1; // math operation for the required param

            if (moreNums != null) // if statement for optional param
            {
                foreach (int i in moreNums) // for each additional optional param...
                {
                    result += i; // ...add to the original result
                }
            }
            return result; // return the end result
        }
           
        
        
    }
}
