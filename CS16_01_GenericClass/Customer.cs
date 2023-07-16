using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS16_01_GenericClass
{
    public class Customer
    {
        // This is our NON-Generic Class | Bu bizim Generic-OLMAYAN Sınıfımız.
        public int id { get; set; }
        public string customerNumber { get; set; }
        public string socialSecurityNumber { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime birthDate { get; set; }

    }
}
