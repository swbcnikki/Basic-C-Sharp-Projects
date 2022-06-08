using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment.cs
{
    public abstract class Person
    {
        public string FirstName { get; set; } // class property
        public string LastName { get; set; } // class property

        public abstract void Name(); // abstract method within abstract class. They do not implement. 
        public virtual void SayName() // method. virtual allows for implementation or override to customize
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
        
    }
}
