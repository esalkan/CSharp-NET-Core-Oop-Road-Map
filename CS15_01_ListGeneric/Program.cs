using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS15_01_ListGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List Generic; ArrayList'in Generic Versiyonudur.
            // List Generic; It is the Generic Version of ArrayList.

            // Objeden Data kabul eden bir yapıdır.
            ArrayList list = new ArrayList();
            list.Add("bir");
            list.Add(1);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------------------------------------");

            // <T> : T tipi demek; .NET framework içerisinde olan veya bizim oluşturduğumuz herhangi bir tip demektir.
            // <T> : means T type; It means any type that is in the .NET framework or that we create.
            
            // Accepts just "Int" type data
            // "Int" türünde data kabul eder
            List<int> listGeneric = new List<int>();
            listGeneric.Add(1);
            listGeneric.Add(2);
            // listGeneric1.Add("one");
            // listGeneric1.Add("two");

            for (int i = 0; i < listGeneric.Count; i++)
            {
                Console.WriteLine(listGeneric[i]);
            }

            foreach (int item in listGeneric)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------------");

            // Accepting just "string" data
            // "String" türünde data kabul eder
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Jane");
            //listGeneric2.Add(1);
            //listGeneric2.Add(2);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("----------------------------------------------");

            // Creating a Generic List.
            // Generic bir liste oluşturalım.
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer()
            {
                id = 1,
                name = "John",
                surname = "DOE"
            });

            foreach (Customer item in customerList)
            {
                Console.WriteLine(item.name + " " + item.surname);
               
            }
        }
    }
}
