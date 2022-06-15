using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment.cs
{
    public class Employee : Person // inheriting from Person class
    {
        public override void Name() // overriding the abstract class
        {
            throw new NotImplementedException();
        }
        public override void SayName() // implementing the method from Person class
        {
            base.SayName();
        }
       
    }
}
