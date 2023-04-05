using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS11_01_Abstraction
{
    public class Customer : BaseClass
    {
        public int customerID { get; set; }

        public Customer()
        {
            customerID = 1;
        }

        // Implementation from Abstract BaseClass
        public override void testAbstractMethod()
        {
            Console.WriteLine("Customer Class => abstractTestMethod()");
        }
    }
}