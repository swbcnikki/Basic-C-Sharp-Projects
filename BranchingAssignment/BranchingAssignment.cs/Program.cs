using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); //name of program
            //first instruction
            int maxWeight = 50;
            Console.WriteLine("Please enter the weight of your package.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > maxWeight)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            
            else
            {
                int maxLength = 50;
                int maxWidth = 50;
                int maxHeight = 50;

                Console.WriteLine("Please enter the width of your package.");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the height of your package.");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                               
                Console.WriteLine("Please enter the length of your package.");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                int maxSize = maxLength * maxWidth * maxHeight;
                int packageSize = packageLength * packageWidth * packageHeight;
                
                if (packageSize > maxSize )
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    decimal shipCost = Convert.ToDecimal(packageSize * packageWeight/100);
                                        
                    Console.WriteLine("Your estimated cost for shipping this package is " + "$" + shipCost);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                    
                }
                



                
            }
            


            
            
        }

    }   
}
