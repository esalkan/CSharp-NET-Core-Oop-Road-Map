using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS10_02_VirtualMethodUsage
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass Constructor Method...");
        }
        // Virtual Method       
        public virtual void writeToScreen(string data)
        {
            Console.WriteLine("BaseClass | Virtual Method => "+ data);
        }

        // Non Virtual Method
        public void writeOnScreen(string virtualData)
        {
            Console.WriteLine(virtualData);
        }
    }
}