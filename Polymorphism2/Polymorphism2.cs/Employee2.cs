using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2.cs
{
    public class Employee2 : Person2, IQuittable2 // inheriting from Person class and IQuittable interface
    {
        public override void Name2() // overriding the abstract class
        {
            throw new NotImplementedException();
        }
        public override void SayName2() // implementing the method from Person class
        {
            base.SayName2();
        }
        public void Quit2() // implementing the Quit method from the IQuittable interface
        {
            Console.WriteLine("This is interface. Don't quit, you are almost there.");            
        }
    }
}
