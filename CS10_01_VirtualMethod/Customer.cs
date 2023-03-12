using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS10_01_VirtualMethod
{
    public class Customer // Object => Framework standart olarak tüm nesneleri object'den üretir.
                          // Object => Framework generates all objects from object as standard.
    {
        public int customerID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        // Virtual Method
        // Manipuating built-in ToString() Method
        public override string ToString()
        {
            return customerID + " " + name + " " + surname;
        }
    }
}
