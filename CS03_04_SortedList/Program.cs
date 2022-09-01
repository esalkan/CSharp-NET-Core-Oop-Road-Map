using System.Collections;

namespace CS03_04_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * SortedList<TKey, TValue>
             * 
             * The SortedList<TKey, TValue>, and SortedList are collection classes that can store key-value pairs
             * that are sorted by the keys based on the associated IComparer implementation. For example, if the keys
             * are of primitive types, then sorted in ascending order of keys.
             * C# supports generic and non-generic SortedList. It is recommended to use generic
             * SortedList<TKey, TValue> because it performs faster and less error-prone than the non-generic SortedList.
             *
             * Important Points :
             *  - The SortedList class implements the IEnumerable, ICollection, IDictionary and ICloneable interfaces.
             *  - In SortedList, an element can be accessed by its key or by its index.
             *  - A SortedList object internally maintains two arrays to store the elements of the list, i.e,
             * one array for the keys and another array for the associated values.
             *  - Here, a key cannot be null, but a value can be.
             *  - The capacity of a SortedList object is the number of key/value pairs it can hold.
             *  - In SortedList, duplicate keys are not allowed.
             *  - In SortedList, we can store values of the same type and of the different types due to the non-generic collection.
             * If we use a generic SortedList in our program, then it is necessary that the type of the values should be the same.
             *  - In SortedList we cannot store keys of different data types in the same SortedList because the compiler will throw an exception.
             * So, always add the key in our SortedList of the same type.
             *  - We can also cast key/value pair of SortedList into DictionaryEntry.
             *
             * --------------------------------------------------------------------------------------------------------
             *
             * SortedList<TAnahtar, TDeğer>
             * 
             * SortedList<TKey, TValue> ve SortedList, ilişkili IComparer implementasyonuna göre
             * anahtarlara göre sıralanan anahtar/değer çiftlerini depolayabilen koleksiyon sınıflarıdır.
             * Örneğin, anahtarlar ilkel türdeyse, artan anahtar sırasına göre sıralanır.
             * C#, jenerik ve jenerik olmayan SortedList'i destekler.
             * Genel olmayan SortedList'ten daha hızlı ve daha az hataya açık olduğundan,
             * genel SortedList<TKey, TValue> kullanılması önerilir.
             *
             * Önemli Noktalar;
             *  - SortedList sınıfı, IEnumerable, ICollection, IDictionary ve ICloneable arabirimlerini uygular.
             *  - SortedList'te, bir öğeye anahtarı veya dizini ile erişilebilir.
             *  - Bir SortedList nesnesi, listenin öğelerini depolamak için dahili olarak iki dizi tutar;
             * yani, anahtarlar için bir dizi ve ilişkili değerler için başka bir dizi.
             *  - Burada bir anahtar boş olamaz, ancak bir değer olabilir.
             *  - SortedList nesnesinin kapasitesi, tutabileceği anahtar/değer çiftlerinin sayısıdır.
             *  - SortedList'te yinelenen anahtarlara izin verilmez.
             *  - SortedList'te, jenerik olmayan koleksiyon nedeniyle aynı türdeki ve farklı türlerdeki değerleri saklayabiliriz.
             * Programımızda jenerik bir SortedList kullanacaksak değerlerin tipinin aynı olması gerekir.
             *  - SortedList'te, derleyici bir istisna atacağından, farklı veri türlerinin anahtarlarını aynı SortedList'te depolayamayız.
             * Bu nedenle, anahtarı her zaman aynı türdeki SortedList'imize ekleriz.
             *  - SortedList'in anahtar/değer çiftini DictionaryEntry'ye de aktarabiliriz.
             *
             * --------------------------------------------------------------------------------------------------------
             *  Properties
             *      - Capacity
             *      - Count
             *      - IsFixedSize
             *      - IsReadOnly
             *      - IsSynchronized
             *      - Item[] (accessing elements)
             *      - Keys
             *      - SyncRoot
             *      - Values
             *
             *  Methods
             *      - Add()
             *      - Clear()
             *      - Clone()
             *      - Contains()
             *      - ContainsKey()
             *      - ContainsValue()
             *      - CopyTo()
             *      - GetByIndex()
             *      - GetEnumerator()
             *      - GetKey()
             *      - GetKeyList()
             *      - GetValueList()
             *      - IndexOfKey()
             *      - IndexOfValue()
             *      - Remove()
             *      - RemoveAt()
             *      - SetByIndex()
             *      - Synchronized()
             *      - TrimToSize()
             */
            
            // General Usage | Genel Kullanım

            #region Creating a SortedList<TKey, TValue>
            Console.WriteLine("\n-----> Creating a SortedList<TKey, TValue> <-----");
            // Creating a SortedList<TKey, TValue>
            // SortedList<TKey, TValue> oluşturma
            SortedList<int, string> sortedList1 = new SortedList<int, string>();
            SortedList sortedList2 = new SortedList();
            #endregion

            #region Add() Method
            Console.WriteLine("\n-----> Add() <-----");
            // Add member to the sortedList1<TKey, TValue>
            sortedList1.Add(100, "Hundred");
            sortedList1.Add(90,"Ninety");
            sortedList1.Add(80, "Eighty");
            sortedList1.Add(70,"Seventy");
            sortedList1.Add(60, "Sixty");
            sortedList1.Add(50,"Fifty");
            
            // Add member to the sortedList2<TKey, TValue>
            sortedList2.Add("Fourty", 40);
            sortedList2.Add("Thirty", 30);
            sortedList2.Add("Twenty", 20);
            sortedList2.Add("Ten",10);
            sortedList2.Add("Zero", 0);
            #endregion

            #region Capacity
            // Capacity
            // Gets or sets the capacity of the SortedList.
            // SortedList'in kapasitesini alır veya ayarlar.
            Console.WriteLine("\n-----> Capacity <-----");
            Console.WriteLine(sortedList2.Capacity);
            #endregion
            
            #region Count
            // Count
            // Gets the number of elements contained in the SortedList.
            // SortedList'te bulunan öğelerin sayısını alır.
            Console.WriteLine("\n-----> Count <-----");
            Console.WriteLine(sortedList2.Count);
            #endregion
            
            #region IsFixedSize
            // IsFixedSize
            // Gets a value indicating whether the SortedList has a fixed size.
            // SortedList'in sabit bir boyutu olup olmadığını gösteren bir değer alır.
            Console.WriteLine("\n-----> IsFixedSize <-----");
            Console.WriteLine(sortedList2.IsFixedSize);
            #endregion
            
            #region IsReadOnly
            // IsReadOnly
            // Gets a value indicating whether the SortedList is read-only.
            // SortedList'in salt okunur olup olmadığını gösteren bir değer alır.
            Console.WriteLine("\n-----> IsReadOnly <-----");
            Console.WriteLine(sortedList2.IsReadOnly);
            #endregion

            #region Item[Key]
            // Accessing SortedList 
            // Item[Key]
            Console.WriteLine("\n-----> Accessing SortedList - Item[Key]<-----");
            Console.WriteLine("sortedList1[100] : ", sortedList1[100]);
            Console.WriteLine("sortedList2[\"Twenty\"] : ", sortedList2["Twenty"]);
            #endregion

            #region Keys
            // Keys
            // Gets the keys in the SortedList.
            // SortedList'teki anahtarları alır.
            Console.WriteLine("\n-----> Keys <-----");
            ICollection sortedList2Keys = sortedList2.Keys;
            foreach (var key in sortedList2Keys)
            {
                Console.WriteLine(key);
            }
            #endregion
            
            #region Values
            // Values
            // Gets the values in the SortedList.
            // SortedList'teki değerleri alır.
            Console.WriteLine("\n-----> Values <-----");
            ICollection sortedList2Values = sortedList2.Values;
            foreach (var value in sortedList2Values)
            {
                Console.WriteLine(value);
            }
            #endregion
            
            #region ContainsKey(object key)
            // ContainsKey()
            // Bir nesnenin belirli bir SortedList anahtar içerip içermediğini belirler.
            // Determines whether a SortedList object contains a specific key.
            Console.WriteLine("\n-----> ContainsKey() <-----");
            Console.WriteLine($"sortedList1.ContainsKey(50) :  {sortedList1.ContainsKey(50)}");
            Console.WriteLine($"sortedList2.ContainsKey(\"Twenty\") :  {sortedList2.ContainsKey("Twenty")}");
            #endregion
            
            #region ContainsValue(object value)
            // ContainsValue()
            // Bir nesnenin belirli bir SortedList değeri içerip içermediğini belirler.
            // Determines whether a SortedList object contains a specific value.
            Console.WriteLine("\n-----> ContainsValue() <-----");
            Console.WriteLine($"sortedList1.ContainsValue(\"Fifty\") :  {sortedList1.ContainsValue("Fifty")}");
            Console.WriteLine($"sortedList2.ContainsValue(20) :  {sortedList2.ContainsValue(20)}");
            #endregion

            #region GetByIndex(int index)
            // GetByIndex(int index)
            // Gets the value at the specified index of a SortedList object.
            // Bir SortedList nesnesinin belirtilen dizinindeki değeri alır.
            Console.WriteLine("\n-----> GetByIndex(int index) <-----");
            Console.WriteLine($"sortedList2.GetByIndex(1) : {sortedList2.GetByIndex(1)}");
            #endregion
            
            #region GetKey(int index)
            // GetKey(int index)
            // Gets the key at the specified index of the SortedList.
            // SortedList'in belirtilen dizinindeki anahtarı alır.
            Console.WriteLine("\n-----> GetKey(int index) <-----");
            Console.WriteLine($"sortedList2.GetKey(1) : {sortedList2.GetKey(1)}");
            #endregion

            #region GetKeyList()
            // GetKeyList()
            // Gets the keys in a SortedList object.
            // Anahtarları bir SortedList nesnesinde alır.
            Console.WriteLine("\n-----> GetKeyList() <-----");
            IList myKeyList = sortedList2.GetKeyList();

            foreach (var key in myKeyList)
            {
                Console.WriteLine(key);
            }
            #endregion
            
            #region GetValueList()
            // GetValueList()
            // Gets the values in a SortedList object.
            // Değerleri bir SortedList nesnesinde alır.
            Console.WriteLine("\n-----> GetValueList() <-----");
            IList myValueList = sortedList2.GetValueList();

            foreach (var key in myValueList)
            {
                Console.WriteLine(key);
            }
            #endregion

            #region IndexOfKey(Object key)
            // IndexOfKey(Object key)
            // Returns the zero-based index of the specified key in a SortedList object.
            // SortedList nesnesinde belirtilen anahtarın sıfır tabanlı dizinini döndürür.
            Console.WriteLine("\n-----> IndexOfKey(Object key) <-----");
            Console.WriteLine("sortedList2.IndexOfKey(\"Ten\") : " + sortedList2.IndexOfKey("Ten"));
            #endregion
            
            #region IndexOfValue(Object value)
            // IndexOfValue(Object value)
            // Returns the zero-based index of the first occurrence of the specified value in the SortedList.
            // SortedList'te belirtilen değerin ilk oluşumunun sıfır tabanlı dizinini döndürür.
            Console.WriteLine("\n-----> IndexOfValue(Object value) <-----");
            Console.WriteLine("sortedList2.IndexOfKey(10) : " + sortedList2.IndexOfValue(10));
            #endregion

            #region Remove(object key)
            // Remove(object key)
            // Removes the element with the specified key dfrom the SortedList
            // Belirtilen anahtara sahip öğeyi SortedList'ten kaldırır.
            Console.WriteLine("\n-----> Remove(object key) <-----");
            sortedList2.Remove("Ten");
            Console.WriteLine("sortedList2.Remove(\"Ten\")");
            foreach (var key in sortedList2.Keys)
            {
                Console.WriteLine(key);
            }
            #endregion
            
            #region RemoveAt(object key)
            // RemoveAt(object key)
            // Removes the element at the specified index of SortedList.
            // SortedList'in belirtilen dizinindeki öğeyi kaldırır.
            Console.WriteLine("\n-----> RemoveAt(object key) <-----");
            sortedList2.RemoveAt(1);
            Console.WriteLine("sortedList2.RemoveAt(1)");
            foreach (var key in sortedList2.Keys)
            {
                Console.WriteLine(key);
            }
            #endregion

            #region TrimToSize()
            // TrimToSize()
            // Sets the capacity to the actual number of elements in the SortedList
            // Kapasiteyi SortedList'teki gerçek eleman sayısına ayarlar
            Console.WriteLine("\n-----> TrimToSize() <-----");
            Console.WriteLine("Before TrimToSize() sortedList2.Capacity : " + sortedList2.Capacity);
            sortedList2.TrimToSize();
            Console.WriteLine("After TrimToSize() sortedList2.Capacity : " + sortedList2.Capacity);
            #endregion

            #region Clear()

            // Clear()
            // Removes all elements from the SortedList.
            // SortedListteki tüm elemanları siler.
            Console.WriteLine("\n-----> Clear() <-----");
            Console.WriteLine("Before Clear() sortedlist1.Count : " + sortedList2.Count);
            sortedList2.Clear();
            Console.WriteLine("After Clear() sortedlist1.Count : " + sortedList2.Count);
            #endregion
        }
    }
}