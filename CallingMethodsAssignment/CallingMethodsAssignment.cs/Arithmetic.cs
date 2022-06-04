using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment.cs

    //Create a class. In that class, create three methods, each of which will take one integer parameter in and
    //return an integer.The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.
{
    public class Arithmetic // The class created through the main program. Public so that it is available everywhere
                            // Solution Explorer > rightclick CallingMethodsAssignment.cs > hover Add > click Class.
                            // On the popup, select Class > name the class at the bottom of the screen > click Add
    {
        public static int Add(int hank) // creating the first method. Public so its available everywhere,
                                                        // static coz it's not instatiated, int, name of method, parameters in parenth.
        {
            int result = hank + hank; // setting up the operation. Notice the variable names here do not match
                                            // the ones when the method is called. The can, but they don't have to.
            return result; // setting what to do with the outcome of the operation. This is a requirement of the method
                           // for it to work. Return is not the only way.
        }
        public static int Subtract(int bill) // method 2 is subtract
        {
            int result = bill - bill; // operation
            return result; // what to do with the outcome
        }
        public static int Multiply(int boomhauer) // method 3 is multiply
        {
            int result = boomhauer * boomhauer; // operation
            return result; // what to do with the outcome
        }
        public static int Divide(int dale) // method 4 is divide
        {
            int result = dale / dale; // opreration
            return result; // what to do with the outcome
        }
    }
}
