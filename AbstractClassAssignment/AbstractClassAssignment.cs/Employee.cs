using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment.cs
{
    public class Employee : Person
    {
        public override void Name()
        {
            throw new NotImplementedException();
        }
        public override void SayName()
        {
            base.SayName();
        }
    }
}
