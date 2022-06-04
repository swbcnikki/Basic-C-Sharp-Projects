using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment.cs
//Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. The methods should do some
//math operation on the received parameter. Put this class in a separate .cs file in the application.

{
    class Program
    {
        public static void Main(string[] args) // Main method of the program. We will be calling the methods we created in the class we created.
        {
            // The values are not hard coded in. Ask the user to provide the value to be processed
            Console.WriteLine("To perform the math operation, please enter any number... "); // value provided is in string and needs to be converted to int
            int yep = Convert.ToInt32(Console.ReadLine()); // converting string to int. Variable name can be anything. It does not need to match the variable
                                                           // name in the called method from Arithmetic class. 


             // calling created methods add, subtract, multiply and divide from the Arithmetic class we created
            int sum = Arithmetic.Add(yep); // passing in the variable declared above and performing the operation
            Console.WriteLine("The sum of itself is " + sum); // displaying the result
                        
            int difference = Arithmetic.Subtract(yep); // passing variable
            Console.WriteLine("The difference of itself is " + difference); // display results
            
            int product = Arithmetic.Multiply (yep); // passing variable
            Console.WriteLine("The product of itself is " + product); // display results
            
            int quotient = Arithmetic.Divide (yep); // passing variable
            Console.WriteLine("The quotient of itself is " + quotient); // display results
            Console.ReadLine(); // keeping the page open to view the results.
        }
               
    }
}
