using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS15_02_GenericList_Perusal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Generic List
            List<int> myNumbers = new List<int>();
            myNumbers.Add(1);

            // ---------------------------------------------------------------------------------

            // Birden fazla değeri aynı anda koleksiyona eklemek istediğimizde.
            // When we want to add multiple values to the collection at the same time.

            // 1.Yol ama uzun bir yol... 
            // 1st Way, but long way...
            int[] dataToAdd = new int[4];
            dataToAdd[0] = 2;
            dataToAdd[1] = 3;
            dataToAdd[2] = 4;
            dataToAdd[3] = 5;

            //for (int i = 0; i < dataToAdd.Length; i++)
            //{
            //    myNumbers.Add(dataToAdd[i]);
            //}

            // 2. Yol, AddRange() Method
            // 2nd Way, AddRange() Method
            myNumbers.AddRange(dataToAdd);

            foreach (int i in dataToAdd)
            {
                Console.WriteLine(i);
            }

            // ---------------------------------------------------------------------------------
            // Capacity
            // Count

            int capacity = myNumbers.Capacity;
            int count = myNumbers.Count;

            // TrimExcess()
            // Sets the capacity to the actual number of elements in the List<T>, if that number is less than a threshold value.
            // apasiteyi List<T>'deki gerçek eleman sayısına ayarlar, eğer bu sayı bir eşik değerinden küçükse.
            myNumbers.TrimExcess();

            capacity = myNumbers.Capacity;
            count = myNumbers.Count;

            // ---------------------------------------------------------------------------------
            // ForEach()
            // => lambda, ilgili koleksiyon içerisinde arama yap ve konsola yazdır. | => List<T> içerisinde Linq konusudur.
            // => lambda, search the related collection and print it to the console.| => is the subject of Linq in List<T>.
            myNumbers.ForEach(item => Console.WriteLine(item));
        }
    }
}
