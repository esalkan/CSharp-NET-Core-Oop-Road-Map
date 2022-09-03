using System;
using System.Collections;
using System.Threading.Channels;

namespace CS03_05_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * STACK
             *
             * It represents a last-in, first out collection of object. It is used when you need a last-in,
             * first-out access of items. When you add an item in the list,
             * it is called pushing the item and when you remove it, it is called popping the item.
             *
             * Stack (yığıt) sınıfı nesnelerin LIFO (last-input-first-output) yapısıyla depolanmasını sağlayan bir veri
             * tipidir. Bilgisayar uygulamalarında çok sık kullanılır. Üst üste konulmuş kutular gibidir. Yani gelen kutu
             * en üste konur. Alttaki ya da aradaki bir kutuyu almak için, en üsttekinden başlayarak, istenen kutuya
             * kadar üsttekileri sırayla almak gerekir. 
             *
             * Properties
             *  - Count
             *
             * Method
             *  - Clear()
             *  - Contains(object obj)
             *  - Peek()
             *  - Pop()
             *  - Push(Object obj)
             *  - ToArray()
             * 
             */

            #region Creating a new Stack

            Console.WriteLine("\n-----> Creating new Stack <----");
            Stack st = new Stack();
            Console.WriteLine("Stack st = new Stack();");
            #endregion

            #region Push(object obj) | Method
            // Push()
            // Inserts an object at the top of the Stack.
            // Yığının üstüne bir nesne ekler.

            Console.WriteLine("\n-----> Push <----");
            
            st.Push("A");
            st.Push("M");
            st.Push("G");
            st.Push("W");
            
            Console.WriteLine("st.Push(\"A\");\n" + "st.Push(\"M\");\n" + "st.Push(\"G\");");

            // Printing current stack elements
            Console.WriteLine("\nCurrent Stack");
            foreach (var ch in st)
            {
                Console.Write(ch + " ");
            }
            #endregion
            
            #region Contains(object obj) | Method
            // Contains(object obj)
            // Determines whether an element is in the Stack.
            // Bir öğenin yığın içinde olup olmadığını belirler.

            Console.WriteLine("\n-----> Contains(object obj) <----");
            Console.WriteLine($"{st.Contains("A")}"); // True
            Console.WriteLine($"{st.Contains("B")}"); // False
            #endregion

            #region Peek() | Method
            // Peek()
            // Returns the object at the top of the Stack without removing it.
            // Yığının(Stack) üstündeki nesneyi kaldırmadan döndürür.
            Console.WriteLine("\n-----> Peek() <-----");
            Console.WriteLine("\nBefore push new elements to the stack, poppable value in stack is : " + st.Peek() + "\n");
            
            st.Push("V");
            st.Push("H");

            Console.WriteLine("st.Push(\"V\");\n" + "st.Push(\"H\");");
            
            Console.WriteLine("\nAfter push new elements to the stack, The next poppable value in stack is : " + st.Peek());
            #endregion

            #region Pop() | Method

            // Pop()
            // Removes and returns the object at the top of the Stack
            // Yığının en üstündeki nesneyi kaldırır ve döndürür.
            Console.WriteLine("\n-----> Pop() <-----");
            Console.WriteLine("Before use Pop() Method :");
            foreach (var ch in st)
            {
                Console.Write(ch + " ");
            }

            // Remove top of the Stack
            st.Pop();
            
            Console.WriteLine("\n\nAfter use Pop() Method :");
            foreach (var ch in st)
            {
                Console.Write(ch + " ");
            }
            #endregion

            #region ToArray() | Method
            // ToArray()
            // Copies the Stack to a new array
            // Yığını yeni bir diziye kopyalar.
            Console.WriteLine("\n-----> ToArray() <-----");
            var stackToArray = st.ToArray();
            
            Console.WriteLine("stackToArray.GetType() : " + stackToArray.GetType());
            foreach (var item in stackToArray)
            {
                Console.Write(item + " ");
            }
            #endregion

            #region Count | Property
            // Count 
            // Gets the number of elements contained in the Stack
            // Yığında bulunan öğelerin sayısını alır.
            Console.WriteLine("\n-----> Count <-----");
            int stCount = st.Count;
            Console.WriteLine($"st.Count result is {stCount}");
            #endregion

            #region Clear() | Method
            // Clear()
            // Removes all elements from the Stack.
            // Yığındaki tüm öğeleri kaldırır.
            Console.WriteLine("\n-----> Clear() <-----");
            Console.WriteLine("Stack status, BEFORE Clear() method call");
            Console.Write("Result is : ");
            foreach (var ch in st)
            {
                Console.Write(ch + " ");
            }
            
            // Remove all elements from the stack
            st.Clear();
            
            Console.WriteLine("\n\nStack status, AFTER Clear() method call");
            Console.Write("Result is : ");
            foreach (var ch in st)
            {
                Console.Write(ch + " ");
            }
            
            #endregion
        }
    }
}