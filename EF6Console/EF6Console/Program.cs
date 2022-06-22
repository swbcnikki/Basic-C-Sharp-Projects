using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF6Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Grumpy" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.WriteLine("Student saved successfully!");
                
                Console.ReadLine();


            }
            
        }
                
    }
}
