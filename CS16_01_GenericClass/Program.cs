using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS16_01_GenericClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Using NON-GENERIC Class | GENERIC-OLMAYAN Sınıfı Kullanma
            Customer c1 = new Customer();
            c1.id = 1;
            c1.socialSecurityNumber = "123456789";
            c1.customerNumber = "CN123";
            c1.name = "John";
            c1.surname = "DOE";
            c1.birthDate = DateTime.Parse("01.01.1981");

            // Using the CustomerGeneric<T> Class | CustomerGeneric<T> Sınıfı Kullanma
            CustomerGeneric<int> customerGeneric1 = new CustomerGeneric<int>();
            customerGeneric1.id = 1;
            customerGeneric1.getCustomerNumber();

            CustomerGeneric<Guid> customerGeneric2 = new CustomerGeneric<Guid>();
            customerGeneric2.getCustomerNumber();

        }
    }
}
