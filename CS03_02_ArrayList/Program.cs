using System;
using System.Collections;


namespace CS03_02_ArrayList
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1- ArrayList
             * It represents ordered collection of an object that can be indexed individually.
             *
             * It is basically an alternative to an array. However, unlike array we can add and remove items
             * from a list at a specified position using an index and the array resizes itself automatically.
             * It also allows dynamic memory allocation, adding, searching and sorting items in the list.
             *
             * --------------------------------------------------------------------------------------------------------
             * 
             * 1- ArrayList
             * Tek tek dizine eklenebilen bir nesnenin sıralı koleksiyonunu temsil eder.
             *
             * Temelde bir diziye bir alternatiftir. Ancak, diziden farklı olarak, bir dizin kullanarak
             * belirli bir konumda bir listeden öğeler ekleyebilir ve kaldırabiliriz ve dizi kendini otomatik olarak
             * yeniden boyutlandırır. Ayrıca listedeki öğeleri dinamik bellek ayırma, ekleme, arama ve sıralama sağlar.
             *
             * --------------------------------------------------------------------------------------------------------
             *
             * METHODS & PROPERTIES of ArrayList Class
             *
             * - PROPERTIES
             *  -> Capacity
             *  -> Count
             *  -> IsFixedSize
             *  -> IsReadOnly
             *  -> Item
             *  -> IsSynchronized
             *  -> SyncRoot
             *
             * METODS
             *  -> Adapter(IList)
             *  -> Add(object value);
             *  -> AddRange(Collection c);
             *  -> BinarySearch();
             *  -> Clear();
             *  -> Clone();
             *  -> Contains(object item);
             *  -> CopyTo();
             *  -> FixedSize();
             *  -> GetEnumerator();
             *  -> GetRange(int index, int count);
             *  -> IndexOf(object);
             *  -> LastIndexOf(object);
             *  -> Insert(int index, object value);
             *  -> InsertRange(int index, ICollection c);
             *  -> ReadOnly();
             *  -> Remove(object obj);
             *  -> RemoveAt(int index)
             *  -> RemoveRange(int index, int count);
             *  -> Repeat();
             *  -> Reverse();
             *  -> SetRange(int index, ICollection c);
             *  -> Sort();
             *  -> Synchronized();
             *  -> ToArray();
             *  -> TrimToSize();
             */
            
            // Creating and declaring an ArrayList
            ArrayList arrayList = new ArrayList();
            
            // Add(object value);
            // Adds an object to the end of the ArrayList.
            // ArrayList'in sonuna bir nesne ekler.
            arrayList.Add(1);
            arrayList.Add(571);
            arrayList.Add(541);
            arrayList.Add(54);
            arrayList.Add(61);
            arrayList.Add(34);
            arrayList.Add(81);
            arrayList.Add(5);
            arrayList.Add(6);

            #region Capacity
            // Capacity
            // Gets or sets the number of elements that the ArrayList can contain.
            // ArrayList'in içerebileceği öğelerin sayısını alır veya ayarlar.
            Console.WriteLine("\n-----> Capacity <-----");
            Console.WriteLine($"Capacity is : {arrayList.Capacity}");
            #endregion

            #region Count
            // Count
            // Gets the number of elements actually contained in the ArrayList.
            // ArrayList içinde gerçekte bulunan öğelerin sayısını alır.
            Console.WriteLine("\n-----> Count <-----");
            Console.WriteLine($"Count is : {arrayList.Count} ");
            #endregion

            #region IsFixedSize
            // IsFixedSize
            // Gets a value indicating whether the ArrayList has a fixed size.
            // ArrayList'in sabit bir boyutu olup olmadığını gösteren bir değer alır.
            Console.WriteLine("\n-----> IsFixed <-----");
            Console.WriteLine($"IsFixedSize : {arrayList.IsFixedSize}");
            #endregion

            #region IsReadOnly
            // IsReadOnly
            // Gets a value indicating whether the ArrayList is read-only
            // ArrayList'in salt okunur olup olmadığını gösteren bir değer alır.
            Console.WriteLine("\n-----> IsReadOnly <-----");
            Console.WriteLine($"IsReadOnly : {arrayList.IsReadOnly}");
            #endregion

            #region Item[]
            // Item
            // Gets or sets the element at the specified index.
            // Belirtilen dizindeki öğeyi alır veya ayarlar.
            Console.WriteLine("\n-----> Item -> arrayList[1] <-----");
            Console.WriteLine($"Item : {arrayList[1]}");
            #endregion

            #region AddRange(ICollection c)
            // AddRange(ICollection c)
            // Adds the elements of an ICollection to the end of the ArrayList.
            // ArrayList'in sonuna bir ICollection öğelerini ekler.
            Console.WriteLine("\n-----> AddRange(ICollection c) <-----");
            // Creates and initializes a new Queue.
            Queue myQueue = new Queue();
            myQueue.Enqueue( "jumps" );
            myQueue.Enqueue( "over" );
            myQueue.Enqueue( "the" );
            myQueue.Enqueue( "lazy" );
            myQueue.Enqueue( "dog" );
            // AddRange(ICollection c)
            // Adds the elements of an ICollection to the end of the ArrayList.
            arrayList.AddRange(myQueue);
            foreach ( Object obj in arrayList )
                Console.Write( "{0}{1}", "\t", obj );
            Console.WriteLine();
            #endregion

            #region Contains
            // Contains(object item)
            // Determines whether an element is in the ArrayList
            // Bir öğenin ArrayList'te olup olmadığını belirler.
            Console.WriteLine("\n-----> Contains(object item) <-----");
            Console.WriteLine($"Contains(object item) : {arrayList.Contains(54)}");
            #endregion

            #region GetRange
            // GetRange(int index, int count);
            // Returns an ArrayList which represents a subset of the elements in the source ArrayList
            // ArrayList kaynağındaki öğelerin bir alt kümesini temsil eden bir ArrayList döndürür.
            Console.WriteLine("\n-----> GetRange(int index, int count); <-----");
            Console.WriteLine($"GetRange : arrayList.GetRange(2,6)");
            foreach (var item in arrayList.GetRange(2,6))
            {
                Console.Write(item + " ");
            }
            #endregion

            #region IndexOf(object)
            // IndexOf(object)
            // Returns the zero-based index of the first occurrence of a value in the ArrayList or in a portion of it.
            // ArrayList'te veya bunun bir bölümünde bir değerin ilk oluşumunun sıfır tabanlı dizinini döndürür.
            Console.WriteLine("\n-----> IndexOf(object) <-----");
            Console.WriteLine($"IndexOf(object) : {arrayList.IndexOf(5)}");
            #endregion

            #region MyRegion
            // LastIndexOf(object)
            // Returns the zero-based index of the last occurrence of a value in the ArrayList or in a portion of it.
            // ArrayList'te veya bunun bir bölümünde bir değerin son oluşumunun sıfır tabanlı dizinini döndürür.
            Console.WriteLine("\n-----> LastIndexOf(object) <-----");
            Console.WriteLine($"LastIndexOf(object) : {arrayList.LastIndexOf(5)}");
            #endregion

            #region Insert(int index, object value)
            // Insert(int index, object value)
            // Insert an element into the ArrayList at the specified index
            // Belirtilen dizinde ArrayList'e bir öğe ekler.
            Console.WriteLine("\n-----> Insert(int index object value) <-----");
            arrayList.Insert(10,"Insert-Method");
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            #endregion

            #region InsertRange(int index, object value)
            // InsertRange(int index, object value);
            // Inserts the elements of a collection into the ArrayList at the specified index.
            // Bir koleksiyonun öğelerini belirtilen dizindeki ArrayList'e ekler.
            Console.WriteLine("\n-----> InsertRange(int index, object value) <-----");
            arrayList.InsertRange(0,myQueue);
            foreach (var item in arrayList)
            {
                Console.Write(item + ", ");
            }
            #endregion

            #region Remove(object obj)
            // Remove(object obj);
            // Removes the first occurence of a specific object from the ArrayList
            // ArrayList'ten belirli bir nesnenin ilk oluşumunu kaldırır.
            Console.WriteLine("\n-----> Remove(object obj) <-----");
            Console.WriteLine("Before Remove()");
            foreach (var before in arrayList)
            {
                Console.Write(before + ", ");
            }

            arrayList.Remove("jumps");
            arrayList.Remove("over");

            Console.WriteLine("\nAfter Remove()");
            foreach (var after in arrayList)
            {
                Console.Write(after + ", ");
            }
            #endregion

            #region RemoveAt(int index)
            // RemoveAt(int index);
            // Removes the element at the specified index of the ArrayList
            // ArrayList'in belirtilen dizinindeki öğeyi kaldırır.
            Console.WriteLine("\n-----> RemoveAt(int index) <-----");
            Console.WriteLine("Before RemoveAt()");
            foreach (var before in arrayList)
            {
                Console.Write(before + ", ");
            }
            
            arrayList.RemoveAt(1);

            Console.WriteLine("\nAfter RemoveAt()");
            foreach (var after in arrayList)
            {
                Console.Write(after + ", ");
            }
            #endregion

            #region RemoveRange(int index, int count)
            // RemoveRange(int index, int count)
            // Removes a range of elements from the ArrayList
            // ArrayList'ten bir dizi öğeyi kaldırır.
            Console.WriteLine("\n-----> RemoveRange(int index, int count) <-----");
            Console.WriteLine("Before RemoveRange()");
            foreach (var before in arrayList)
            {
                Console.Write(before + ", ");
            }
            
            arrayList.RemoveRange(6,4);
            
            Console.WriteLine("\nAfter RemoveRange()");
            foreach (var after in arrayList)
            {
                Console.Write(after + ", ");
            }
            #endregion

            #region Reverse()
            // Reverse()
            // Reverses the order of the elements in the ArrayList
            // ArrayList'teki veya bunun bir bölümündeki öğelerin sırasını tersine çevirir.
            Console.WriteLine("\n-----> Reverse() <-----");
            Console.WriteLine("Before Reverse()");
            foreach (var before in arrayList)
            {
                Console.Write(before + ", ");
            }
            
            arrayList.Reverse();
            
            Console.WriteLine("\nAfter Reverse()");
            foreach (var after in arrayList)
            {
                Console.Write(after + ", ");
            }
            #endregion

            #region SetRange(int index, ICollection c)
            Console.WriteLine("\n-----> SetRange(int index, ICollection c) <-----");
            // SetRange(int index, ICollection c)
            // Copies the elements of a collection over a range of elements in the ArrayList
            // Bir koleksiyonun öğelerini ArrayList'teki bir dizi öğe üzerine kopyalar.
            arrayList.SetRange(2,myQueue);
            foreach (var item in arrayList)
            {
                Console.Write(item + ", ");
            }
            #endregion

            #region MyRegion
            Console.WriteLine("\n-----> Sort() <-----");
            // Sort()
            // Sorts the elements in the ArrayList
            // ArrayList'teki veya bunun bir bölümündeki öğeleri sıralar.
            
            arrayList.Clear();
            
            arrayList.Add(1);
            arrayList.Add(571);
            arrayList.Add(541);
            arrayList.Add(54);
            arrayList.Add(61);
            arrayList.Add(34);
            arrayList.Add(81);
            arrayList.Add(5);
            arrayList.Add(6);
            
            arrayList.Sort();
            foreach (var item in arrayList)
            {
                Console.Write(item + ", ");
            }
            #endregion

            #region TrimToSize()
            Console.WriteLine("\n-----> TrimToSize() <-----");
            // TrimToSize()
            // Sets the capacity to the actual number of elements in the ArrayList
            // Kapasiteyi içindeki gerçek öğe ArrayListsayısına ayarlar.
            arrayList.TrimToSize();
            Console.WriteLine(arrayList.Count);
            #endregion

            #region Example

            string userSelection = string.Empty;
            ArrayList valueList = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Add Value");
                Console.WriteLine("2 - List Value");
                Console.WriteLine("3 - Search Value");
                Console.WriteLine("4 - Edit Value");
                Console.WriteLine("5 - Delete Value");
                Console.WriteLine("6 - App Exit");
                Console.Write("Please choose: ");
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        Console.Write("Please enter the value you want to add:");
                        string userValue = Console.ReadLine();
                        valueList.Add(userValue);
                        Console.WriteLine("Your value has been successfully added");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "2":
                        for (int i = 0; i < valueList.Count; i++)
                        {
                            Console.WriteLine("{0}. Değer = {1}", i, valueList[i]);
                        }
                        Console.WriteLine("Press a button to continue.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Enter the value you want to search");
                        string userSearchValue = Console.ReadLine();
                        bool control = valueList.Contains(userSearchValue);
                        if (control)
                        {
                            int foundedIndex = valueList.IndexOf(userSearchValue);
                            string foundedValue = valueList[foundedIndex].ToString();
                            Console.WriteLine("Your Value Found: index order :{0} - Value : {1}", foundedIndex, foundedValue);
                        }
                        else
                        {
                            Console.WriteLine("No value found for your search criteria");
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "4":

                        Console.WriteLine("Enter the value you want to update:");
                        string userValueToEdit = Console.ReadLine();

                        Console.WriteLine("What value do you want to update {0} with?", userValueToEdit);
                        string userNewValue = Console.ReadLine();

                        if(valueList.Contains(userValueToEdit))
                        {
                            int userTargetIndex = valueList.IndexOf(userValueToEdit);
                            valueList[userTargetIndex] = userNewValue;
                            Console.WriteLine("Your value has been updated");
                        }
                        else
                        {
                            Console.WriteLine("The value you are looking for was not found in the list.");
                        }

                        System.Threading.Thread.Sleep(2000);

                        break;
                    case "5":
                        Console.WriteLine("Do you want to delete all values (Y/N)");
                        string userDeleteAnswer = Console.ReadLine();

                        if(userDeleteAnswer.ToUpper() == "E")
                        {
                            valueList.Clear();
                            Console.WriteLine("All values are deleted");
                        }
                        else
                        {
                            Console.WriteLine("Enter the value you want to delete in the list");
                            string userDeleteValıe = Console.ReadLine();
                            if(valueList.Contains(userDeleteValıe))
                            {
                                valueList.Remove(userDeleteValıe);
                                Console.WriteLine("Your Value Has Been Deleted");
                            }
                            else
                            {
                                Console.WriteLine("The value you want to delete does not exist in the list.");
                            }
                        }

                        break;
                    default:
                        break;
                }
            } while (userSelection != "6");

            #endregion
        }
    }
}