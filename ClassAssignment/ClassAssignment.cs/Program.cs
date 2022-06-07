using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            HalfParam halfParam = new HalfParam(); // instance

            Console.WriteLine("Please type in a number...");
            int number = Convert.ToInt32(Console.ReadLine());

            halfParam.Pinto(number);
            Console.ReadLine();

                        
            halfParam.Pinto(out int number2); // calling out param
            Console.WriteLine("The value of the out param is {0}", number2);
            Console.ReadLine();

            Console.WriteLine("Type in a number and see it double");
            int wheels = Convert.ToInt32(Console.ReadLine());

            int number1 = StaticClass.Dunebuggy(wheels);
            Console.WriteLine("Your new number is " + number1);
            Console.ReadLine();
        }
        


    }
}
