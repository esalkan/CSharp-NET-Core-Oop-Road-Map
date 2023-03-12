using System.Globalization;

namespace CS10_01_VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * In C#, a virtual method is a method that can be overridden in a derived class.
             * When a method is declared as virtual in a base class, it allows a derived class to
             * provide its own implementation of the method.
             * 
             * To declare a method as virtual in C#, the "virtual" keyword is used in the method 
             * declaration in the base class.
             * 
             * ---------------------------------------------------------------------------------
             * 
             * C#'ta sanal bir yöntem, türetilmiş bir sınıfta geçersiz kılınabilen bir yöntemdir 
             * Bir yöntem, bir temel sınıfta sanal olarak bildirildiğinde, türetilmiş bir 
             * sınıfın, yöntemin kendi uygulamasını sağlamasına izin verir.
             * 
             * C#'ta bir yöntemi sanal olarak bildirmek için, temel sınıftaki yöntem bildiriminde
             * "virtual" anahtar sözcüğü kullanılır.
            */

            // Object => ToString();

            /*
             * Customer C1 = new Customer();
             * 
             * Object => Customer
             *           C1.ToString();
             *           
             * Namespace.Customer
             * 
             * 
             */

            // Let's take an object instance from the customer object.
            // Müşteri nesnesinden bir nesne örneği alalım.
            Customer C1 = new  Customer();
            C1.customerID = 1;
            C1.name = "Nasreddin";
            C1.surname = "HOCA";

            string toStringMessage = C1.ToString();

            Console.WriteLine(toStringMessage);
        }
    }
}