using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_02_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseTypes BT1 = new BaseTypes();
            BT1.BaseTypeMethod1();
            
            Instructor instructor1 = new Instructor();
            Console.WriteLine("The Instructor object is instantiated.");
            instructor1.BaseTypeMethod1();
            
        }
    }
}