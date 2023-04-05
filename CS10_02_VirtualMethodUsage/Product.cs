using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS10_02_VirtualMethodUsage
{
    public class Product : BaseClass
    {
        public Product()
        {
            Console.WriteLine("Product Class Constructor Method...");
        }

        // Overrided Method from BaseClass 
        public override void writeToScreen(string data)
        {
            // base.writeOnScreen(virtualData);
            Console.WriteLine("Product Class | Overrided method => " + data);
        }
    }
}