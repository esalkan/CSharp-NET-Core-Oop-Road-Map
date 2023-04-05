using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS11_01_Abstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            // We can not instantiate the base class if it is Abstract Class.
            // Temel sınıfı Abstract Class ise örnekleyemeyiz.
            // BaseClass B1 = new BaseClass();

            Customer C1 = new Customer();
            C1.testMethod();
            C1.testAbstractMethod();


            /********************************/

            SuperCustomer SpC1 = new SuperCustomer();
            SpC1.testAbstractMethod();  // testAbstractMethod() is in BaseClass
            // BaseClass içerisindeki testAbstractMethod()


        }
    }
}