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

            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // Capacity
            // Count

            int capacity = myNumbers.Capacity;
            int count = myNumbers.Count;

            // TrimExcess()
            // Sets the capacity to the actual number of elements in the List<T>, if that number is less than a threshold value.
            // Kapasiteyi List<T>'deki gerçek eleman sayısına ayarlar (Eşitler), eğer bu sayı bir eşik değerinden küçükse.
            myNumbers.TrimExcess();

            capacity = myNumbers.Capacity;
            count = myNumbers.Count;

            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // ForEach()
            // "=>" Lambda ifadesidir.
            // => lambda, ilgili koleksiyon içerisinde arama yap ve konsola yazdır. | => List<T> içerisinde Linq konusudur.
            // => lambda, search the related collection and print it to the console.| => is the subject of Linq in List<T>.
            myNumbers.ForEach(item => Console.WriteLine(item));
            
            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------
            
            // İşaret edilen index'te olan değeri alma.
            // Get the value at the pointed index.
            int containedValue = myNumbers[3];
            Console.WriteLine("List<T> koleksiyonu içerisinde 3. index'de bulunan değer {0}", containedValue);
            Console.WriteLine("The value at index 3 in the List<T> collection is {0}", containedValue);
            
            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // Insert() Method
            // ForEach() Method

            // The Insert method is used to insert an item into the middle of the list.
            // The item inserted is a duplicate, which is later removed using the Remove method.

            // Insert yöntemi, listenin ortasına bir öğe eklemek için kullanılır.
            // Eklenen öğe bir kopyadır ve daha sonra Remove yöntemi kullanılarak kaldırılır
            Console.WriteLine("Insert() & ForEach()");
            myNumbers.Insert(3, 100);
            myNumbers.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // Any() Method
            Console.WriteLine("Any()");
            bool control1 = myNumbers.Any();
            bool control2 = myNumbers.Any(item => item > 5);

            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // Sort() Method 

            // Sorts the elements or a portion of the elements in the List<T> using either the specified or
            // default IComparer<T> implementation or a provided Comparison<T> delegate to compare list elements.

            // Liste öğelerini karşılaştırmak için belirtilen veya varsayılan IComparer<T> uygulamasını ya da
            // sağlanan bir Comparison<T> temsilcisini kullanarak List<T> içindeki öğeleri veya öğelerin bir kısmını sıralar.
            Console.WriteLine("Sort()");
            myNumbers.Sort(); // A-Z | 1 - N..

            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // Reverse() Method

            // Reverses the order of the elements in the List<T> or a portion of it.
            // List<T>'deki veya bir bölümündeki öğelerin sırasını tersine çevirir.
            Console.WriteLine("Reverse()");
            myNumbers.Reverse(); // Z-A | N...- 1

            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // Remove() Method
            // Removes the first occurrence of a specific object from the List<T>.
            // List<T> listesinden belirli bir nesnenin ilk geçtiği yeri kaldırır.
            Console.WriteLine("Remove()");
            bool removeResult = myNumbers.Remove(100);

            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // Max() Method
            // Getting highest value in List<T>
            // List<T> listesindeki en yüksek değeri alır.
            Console.WriteLine("Max()");
            int highestValue = myNumbers.Max();
            Console.WriteLine(highestValue);

            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // Min() Method
            // Getting lowest value in List<T>
            // List<T> listesindeki en küçük değeri alır.
            Console.WriteLine("Min()");
            int lowestValue = myNumbers.Min();
            Console.WriteLine(lowestValue);

            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // Sum() Method
            // List<T> eleman değerlerinin toplamını alır.
            // List<T> gets the sum of the element values.
            Console.WriteLine("Sum()");
            int sumValue = myNumbers.Sum();
            Console.WriteLine(sumValue);

            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // RemoveAll()
            // Removes all the elements that match the conditions defined by the specified predicate.
            // Belirtilen yüklem tarafından tanımlanan koşullarla eşleşen tüm öğeleri kaldırır.
            // myNumbers.RemoveAll(item => item > 3);
            Console.WriteLine("RemoveAll()");
            int deletedQuantity = myNumbers.RemoveAll(item => item > 3);

            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // RemoveAt() Method
            // Removes the element at the specified index of the List<T>.
            // List<T>'nin belirtilen dizinindeki öğeyi kaldırır.
            Console.WriteLine("RemoveAt()");
            myNumbers.RemoveAt(2); // That will removed index 2 value | Index 2'de bulunan değeri kaldırır.

            Console.WriteLine("---------------------------------------------------------");
            // ---------------------------------------------------------------------------------

            // Clear() Method
            // Removes all elements from the List<T>.
            // List<T>'den tüm öğeleri kaldırır.
            Console.WriteLine("Clear()");
            myNumbers.Clear();
        }
    }
}
