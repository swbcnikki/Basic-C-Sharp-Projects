using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment.cs
{


    //*** THIS PROGRAM DOES NOT WORK *** REDONE AS POLYMORPHISM2



    public class Employee : Person, IQuittable // inheriting from Person class and IQuittable interface
    {
        public override void Name() // overriding the abstract class
        {
            throw new NotImplementedException();
        }
        public override void SayName() // implementing the method from Person class
        {
            base.SayName();
        }
        public void Quit() // implementing the Quit method from the IQuittable interface
        {
            Console.WriteLine("This is interface");
        }
    }
}
