using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment.cs

//Create a class. In that class, create a method that will take in an integer, create a math operation
//for this integer (addition, subtraction, etc.), then return the answer as an integer.
{
    class Program
    {
        public static void Main(string[] args)   // public for access everywhere
        {
            //instantiate the class and call the first method, passing in an integer then return the answer as an integer. Display the result to the screen.

            Variety intOp = new Variety();    // instance of intOP     
            int sum = intOp.Plus(3);        // math operation
            Console.WriteLine(sum);         // Display result

            //instantiate the class and call the second method, passing in a decimal then return the answer as an integer. Display the result to the screen.
            Variety decOp = new Variety();      // instance of decOp      
            int prod = (int)decOp.Square(5.3m); // math operation
            Console.WriteLine(prod);            // Display result


            //instantiate the class and call the third method, passing in a string that equates to an integer then return the answer as an integer. Display the result to the screen.
            Variety strOp = new Variety();       // instance of strOp     
            int prod2 = (int)strOp.Cube("3");   // math operation
            Console.WriteLine(prod2);           // Display result           
            Console.ReadLine();
        }

    }
}
