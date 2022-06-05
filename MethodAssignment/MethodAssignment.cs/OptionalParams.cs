using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment.cs
{
    class OptionalParams
    {
        public int Addition(int num1)
        {           
            Addition(num1, null);
            int result = num1 + num1;
            return result;

        }

        public int Addition(int num1, int[] moreNums)
        {
            int result = num1 + num1;

            if (moreNums != null)
            {
                foreach (int i in moreNums)
                {
                    result += i;
                }
            }
            return result;
        }
           
        
        
    }
}
