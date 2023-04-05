using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS11_01_Abstraction
{
    public abstract class BaseClass
    {
        public DateTime registrationDate { get; set; }
        public DateTime updateDate { get; set; }

        public BaseClass()
        {
            registrationDate = DateTime.Now;
            updateDate = DateTime.Now;
        }

        public void testMethod()
        {
            Console.WriteLine("Base Class => testMethod() run...");
        }

        // Abstract Methods will not have method body.
        public abstract void testAbstractMethod();
        //{
        //    Console.WriteLine();
        //}
    }
}