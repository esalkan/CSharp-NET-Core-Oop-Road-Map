using System.Collections;

namespace CS03_06_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * QUEUE
             *
             * It represents a first-in, first out collection of object.
             * It is used when we need a first-in, first-out access of items.
             * When we add an item in the list, it is called enqueue,
             * and
             * when we remove an item, it is called deque.
             *
             *
             * İlk giren ilk çıkar nesne koleksiyonunu temsil eder.
             * Öğelerin ilk giren ilk çıkar erişimine ihtiyaç duyduğumuzda kullanılır.
             * Listeye bir öğe eklemek istediğimizde "enqueue",
             * ve
             * bir öğeyi kaldırmak istediğimizde "deque" kullanılır.
             *
             * Properties
             *  - Count
             *  - IsSynchronized
             *  - SyncRoot
             *
             * Methods
             *  - Clear
             *  - Clone
             *  - Contains
             *  - CopyTo
             *  - Dequeue
             *  - Enqueue
             *  - GetEnumerator
             *  - Peek
             *  - Synchronized
             *  - ToArray
             *  - TrimToSize
             */

            #region Creating new Queue
            // Creating new Queue
            Console.WriteLine("-----> Creating new Queue <-----");
            Console.WriteLine("Queue qe = new Queue();");
            Queue qe = new Queue();
            #endregion

            #region Enqueue(object obj) | Method
            // Enqueue(object obj)
            // Adds an object to the end of the Queue.
            // Kuyruğun sonuna bir nesne ekler.
            Console.WriteLine("\n-----> Enqueue(object obj) <-----");
            qe.Enqueue("A");
            qe.Enqueue("M");
            qe.Enqueue("G");
            qe.Enqueue("T");
            qe.Enqueue("R");

            Console.WriteLine("qe.Enqueue(\"A\");" + "\n" + "qe.Enqueue(\"M\");" + "\n" + "qe.Enqueue(\"G\");" + "\n" + "qe.Enqueue(\"T\")" + "\n" + "qe.Enqueue(\"R\");");
            #endregion

            #region Count | Property
            // Count
            // Gets the number of elements contained in the Queue
            // Kuyrukta(Queue) bulunan öğelerin sayısını alır.
            Console.WriteLine("\n-----> Count <-----");
            int qeCount = qe.Count;
            Console.WriteLine($"Result is : {qeCount}");
            #endregion

            #region Contains(object obj) | Method
            // Contains(object obj)
            // Determines whether an element is in the Queue. It has typing sensitivity.
            // Bir öğenin Kuyrukta(Queue) olup olmadığını döndürür. Yazım hassasiyeti vardır
            Console.WriteLine("\n-----> Contains(object obj) <-----");
            bool qeContainsResult = qe.Contains("A"); // True
            Console.WriteLine(qeContainsResult); // True
            
            Console.WriteLine(qe.Contains("M")); // True
            Console.WriteLine(qe.Contains("m")); // False
            #endregion

            #region Dequeue() | Method
            // Dequeue()
            // Removes and returns the object at the beginning of the Queue
            // Kuyruğun(Queue) başındaki nesneyi kaldırır ve sonucu döndürür.
            Console.WriteLine("\n-----> Dequeue() <-----");
            
            Console.WriteLine("Before Dequeue() Queue object status.");
            foreach(var ch in qe) Console.Write(ch + " ");
            
            // Remove 
            qe.Dequeue();

            Console.WriteLine("\nAfter Dequeue() Queue object status");
            foreach(var ch in qe) Console.Write(ch + " ");
            #endregion

            #region ToArray() | Method
            // ToArray()
            // Copies the Queue to a new array.
            // Kuyruğu(Queue) yeni bir diziye kopyalar.
            Console.WriteLine("\n-----> ToArray() <-----");
            qe.ToArray();
            Console.WriteLine(qe.GetType());
            #endregion
            
            #region TrimToSize() | Method
            // TrimToSize()
            // Sets the capacity to the actual number of elements in the Queue
            // Kuyruktaki(Queue) gerçek öğe sayısına kapasiteyi ayarlar.
            Console.WriteLine("\n-----> TrimToSize() <-----");
            qe.TrimToSize();
            Console.WriteLine("qe.TrimToSize()");
            #endregion

            #region Clear() | Method
            // Clear()
            // Removes all elements from the Queue.
            // Kuyruktaki tüm nesneleri temizler.
            Console.WriteLine("\n-----> Clear() <-----");
            Console.WriteLine("BEFORE Clear() method run, Queue Count is : " + qe.Count);
            qe.Clear();
            Console.WriteLine("AFTER Clear() method run, Queue Count is : " + qe.Count);
            #endregion

        }
    }
}