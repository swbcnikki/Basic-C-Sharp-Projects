using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloadAssignment.cs
{
    public class Employees : Person
    {
       
        public static bool operator == (Employees emp1, Employees emp2)
        {          
            return emp1.empId == emp2.empId;
        }
        public static bool operator != (Employees emp1, Employees emp2)
        {
            return emp1.empId != emp2.empId;
        }
    }
}
