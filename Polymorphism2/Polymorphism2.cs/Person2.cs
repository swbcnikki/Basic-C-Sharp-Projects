using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2.cs
{
    public abstract class Person2
    {
        public string FirstName2 { get; set; } // class property
        public string LastName2 { get; set; } // class property

        public abstract void Name2(); // abstract method within abstract class. They do not implement. 
        public virtual void SayName2() // method. virtual allows for implementation or override to customize
        {
            Console.WriteLine("Name: {0} {1}", FirstName2, LastName2);            
        }
    }
}
