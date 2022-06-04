using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment.cs

//Create a class. In that class, create a method that will take in an integer, create a math operation
//for this integer (addition, subtraction, etc.), then return the answer as an integer.
{
   public class Variety
    {
        public int Plus(int bubbles) // creating the first method. Public so its available everywhere,
                                       // there is no static because we are instatiating, data type int, name of method, parameters in parenth.
        {
            int result = bubbles + bubbles; // setting up the operation. Notice the variable names here do not match the
                                      // ones when the method is called. The can, but they don't have to.
            return result; // setting what to do with the outcome of the operation. This is a requirement of the method
                           // for it to work. Return is not the only way.
        }

        public decimal Square(decimal blossom) // datatype decimal, method 2 is square
        {
            int result = (int) (blossom * blossom); // operation
            return result; // what to do with the outcome
        }

        public int Cube(string buttercup) // datatype string, method 2 is cube
        {            
            int buttercup1 = Convert.ToInt32(buttercup);                
  
            int result = buttercup1 * buttercup1 * buttercup1; // operation
            return result; // what to do with the outcome
        }
    }
}
