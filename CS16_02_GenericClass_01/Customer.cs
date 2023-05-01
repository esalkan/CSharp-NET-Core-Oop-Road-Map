using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS16_02_GenericClass_01
{
    public class Customer
    {
        // Creating our SQL Table copy
        public int Id { get; set; }
        public Guid customerNumber { get; set; } // Guid: Unique Identifier
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime birthDate { get; set; }
    }
}
