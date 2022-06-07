using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.cs
{
    //Create a class. In that class, create a void method that outputs an integer.Have the method divide the
    //data passed to it by 2.
    class HalfParam
    {
        public void Pinto(int number) // method
        {
            int result = number / 2;
            Console.WriteLine(result);
        }
        public void Pinto(int number, int number1) // for method overload. Gives a 2nd option.
        {
            
            int result = (number / 2) + number1;            
        }

        public void Pinto(out int number2) // overload 3rd option
        {
            number2 = 20;
            number2 -= number2;
        }

    }
}
