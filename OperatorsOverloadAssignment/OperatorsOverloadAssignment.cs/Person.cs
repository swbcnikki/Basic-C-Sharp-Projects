using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloadAssignment.cs
{
    public class Person
    {
        public string FirstName { get; set; } // class property
        public string LastName { get; set; } // class property
        public int empId { get; set; }

        public void Record()
        {
            Console.WriteLine(" Employee: {0} {1} (3}", empId, LastName, FirstName);
        }

        
    }
}
