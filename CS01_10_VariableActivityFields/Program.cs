using System.Threading.Channels;
using System;

namespace CS01_10_VariableActivityFields
{
    class Program
    {
        // Class level variable
        static string str2 = "str2 Class Level Variable Value";
            
        static void Main(string[] args)
        {
            string str1 = "str1 in Main Method";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
        
        public static void TestMethod()
        {
            // str1 is just reachable in main method because it is initialized in main method block
            // str1 = "str1 in TestClass Method";
            
            // str2 is class level variable and we can use it in class level
            // str2 klass seviyesi değişkendir ve class içerisinde kullanılabilir.
            Console.WriteLine(str2);
        }
        
    }
}
