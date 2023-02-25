using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_05_ObjectModelling
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff s1 = new Staff();
            s1.BaseTypeMethod1();

            Student student1 = new Student();
            student1.BaseTypeMethod1();

            object Obj1 = student1;     // Boxing
            student1 = (Student)Obj1;   // Un-boxing
        }
    }
}