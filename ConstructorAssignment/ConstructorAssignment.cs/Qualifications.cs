using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment.cs
{
    //Chaining two constructors together
    public class Qualifications
    {
        public Qualifications(string availability) : this(availability, "yes")
        {
        }
        public Qualifications(string availability, string capability)
        {
            List<string> DeathList = new List<string>();
            var When = availability; // creating variable using var
            var Will = capability; // creating variable using var
        }
    }
}


/*Perform these actions and create a console app that includes the following:


Create a const variable.

Create a variable using the keyword “var.”

Chain two constructors together.

Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. */