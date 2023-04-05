using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS10_02_VirtualMethodUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product P1 = new Product();
            P1.writeToScreen("This method in BaseClass was called from within the product object.");
            P1.writeToScreen("BaseClass içerisindeki bu method ürün nesnesi içerisinden  çağırıldı.");
            P1.writeToScreen("Hello C#!");

            Console.WriteLine();

            BaseClass B1 = new BaseClass();
            B1.writeToScreen("This method in BaseClass was called directly from the BaseClass object.");
            B1.writeToScreen("BaseClass içerisindeki bu method direk BaseClass nesnesi içerisinden  çağırıldı.");
            B1.writeToScreen("Base Class.");

            Console.WriteLine();

            Computer C1 = new Computer();
            C1.writeToScreen("Computer...");
        }
    }
}