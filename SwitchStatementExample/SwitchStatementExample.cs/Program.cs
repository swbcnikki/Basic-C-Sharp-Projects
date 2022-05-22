using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatementExample.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 6;
            switch (month)
            {
                case 1:
                    Console.WriteLine("March");
                    break;
                case 2:
                    Console.WriteLine("April");
                    break;
                case 3:
                    Console.WriteLine("May");
                    break;
                case 4:
                    Console.WriteLine("June");
                    break;
                case 5:
                    Console.WriteLine("July");
                    break;
                case 6:
                    Console.WriteLine("August");
                    break;
                case 7:
                    Console.WriteLine("September");
                    break;
                case 8:
                    Console.WriteLine("October");
                    break;
                case 9:
                    Console.WriteLine("November");
                    break;
                case 10:
                    Console.WriteLine("December");
                    break;
                case 11:
                    Console.WriteLine("January");
                    break;
                case 12:
                    Console.WriteLine("February");
                    break;                
            }
            Console.ReadLine();
        }
    }
}
