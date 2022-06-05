using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment.cs
{
    class Program
    {
        public static void Main(string[] args)        
        {
            OptionalParams option = new OptionalParams(); // instance

            Console.WriteLine("Type in a number for the operation to execute..."); // user question
            int digit = Convert.ToInt32(Console.ReadLine()); // converting input to int

            int sum = option.Addition(digit); //calling the method

            Console.WriteLine(sum); // operation and displaying the result
            Console.ReadLine(); // keep console open to view result

            Console.WriteLine("If you would like, type in a second number..."); // question option for user
            int i = Convert.ToInt32(Console.ReadLine()); // converting to int         
            if (i != null) // if i has an int value, perform the operation below
            {
                int sum1 = option.Addition(i); // calling the method
                Console.WriteLine(sum + i); // operation and displaying the result
                Console.ReadLine(); // keep the screen open
            }
            else // THIS PART IS NOT WORKING. I HAVE NOT BEEN ABLE TO FIGURE IT OUT AND AFTER SEVERAL TRIES, I THINK I WILL WAIT FOR HELP ON MONDAY
            {
                Console.WriteLine(sum); // display the original answer if i does not have a value
                Console.ReadLine(); // keep the screen open

            }
        }
                
        
    }

}
    

