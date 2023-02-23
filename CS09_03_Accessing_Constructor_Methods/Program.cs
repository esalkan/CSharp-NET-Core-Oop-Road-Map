using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_03_Accessing_Constructor_Methods{

class Program
{
    static void Main(string[] args)
    {
        BaseTypes Bt = new BaseTypes();
        Bt.BaseTypeMethod1();

        Console.WriteLine();

        Instructor instructor = new Instructor();
        instructor.BaseTypeMethod1();
    }
}
}