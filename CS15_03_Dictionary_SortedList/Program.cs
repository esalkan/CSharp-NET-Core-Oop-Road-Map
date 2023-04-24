using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS15_03_Dictionary_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * NON GENERIC COLLECTION
             * 
             * The Hashtable is a non-generic collection that stores key-value pairs, 
             * similar to generic Dictionary<TKey, TValue> collection. 
             * It optimizes lookups by computing the hash code of each key and stores it in a different bucket internally 
             * and then matches the hash code of the specified key at the time of accessing values.
             * 
             * Hashtable, genel Dictionary<TKey, TValue> koleksiyonuna benzer şekilde, 
             * anahtar-değer çiftlerini depolayan genel olmayan bir koleksiyondur. 
             * Her anahtarın karma kodunu hesaplayarak aramaları optimize eder 
             * ve bunu dahili olarak farklı bir kovada saklar ve ardından değerlere erişim sırasında belirtilen 
             * anahtarın karma koduyla eşleşir.
             */
            Hashtable HTList = new Hashtable();
            HTList.Add("The Key","The Value");
            HTList.Add(1, "One");
            HTList.Add(2, "Two");
            HTList.Add(3, "Tree");
            // HTList.Add(1, "Bir"); // Throws run-time exception: key already added. | Çalışma zamanı hatası döndürür: anahtar zaten eklendi.

            HTList.Remove(1);

            /*
             * GENERIC COLLECTIONS
             * 
             * Dictionary<TKey, TValue>
             * - Dictionary is the generic version of hash table.
             * The Dictionary<TKey, TValue> is a generic collection that stores key-value pairs in no particular order.
             * 
             * Dictionary Characteristics
             *  - Dictionary<TKey, TValue> stores key-value pairs.
             *  - Comes under System.Collections.Generic namespace.
             *  - Implements IDictionary<TKey, TValue> interface.
             *  - Keys must be unique and cannot be null.
             *  - Values can be null or duplicate.
             *  - Values can be accessed by passing associated key in the indexer e.g. myDictionary[key]
             *  - Elements are stored as KeyValuePair<TKey, TValue> objects.
             *  
             *  
             *  Dictionary<TKey, TValue>, anahtar/değer çiftlerini belirli bir sırada depolayan genel bir koleksiyondur.
             *  - Dictonary hashtable'in generik halidir.
             *  Sözlük Özellikleri
             *  - Dictionary<TKey, TValue>, anahtar/değer çiftlerini saklar.
             *  - System.Collections.Generic ad alanı altında gelir.
             *  - IDictionary<TKey, TValue> arabirimini uygular.
             *  - Anahtarlar benzersiz olmalıdır ve boş olamaz.
             *  - Değerler boş olabilir veya yinelenebilir.
             *  - Değerlere, dizin oluşturucudaki ilişkili anahtarı geçirerek erişilebilir, örn. sözlüğüm[anahtar]
             *  - Öğeler, KeyValuePair<TKey, TValue> nesneleri olarak depolanır.
             *  
             */

            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();
            DictionaryList.Add(1, "One");
            DictionaryList.Add(2, "Two");
            DictionaryList.Add(3, "Tree");
            DictionaryList.Add(4, "Four");
            // DictionaryList.Add(1, "Bir"); // System.ArgumentException: 'An item with the same key has already been added.' | System.ArgumentException: 'Aynı anahtara sahip bir öğe zaten eklenmiş.'

            // Dictonary Methods
            bool deleteResult = DictionaryList.Remove(4);
            if (deleteResult == true)
            {
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("The delete operation failed.");
            }

            // Accessing values using keys. | Anahtarları kullanarak verilere erişmek.
            var returnedValue = DictionaryList[2];
            Console.WriteLine(returnedValue);

            // Changing the Key's value | Anahtarın değerini değiştirme
            string returnedValueForChange = DictionaryList[3];
            returnedValueForChange = "The new Value for the key 3";
            DictionaryList[3] = returnedValueForChange;


            // Changing the Key's value with control | Changing the value of Key by checking.
            bool searchedValueResult = DictionaryList.ContainsKey(4);

            if (searchedValueResult == true)
            {
                string valueForChange = DictionaryList[4];
                valueForChange = "The new Value for the key 4";
                DictionaryList[4] = valueForChange;
            } else
            {
                Console.WriteLine("Searched Key is not found in Dictonary<TKey, TValue> Collection");
            }

            // Changing the Key's value with control | Changing the value of Key by checking.
            bool containedValueResult = DictionaryList.ContainsValue("4");

            if (containedValueResult == true)
            {
                Console.WriteLine("The Value is found");
            }
            else
            {
                Console.WriteLine("The Value is NOT FOUND!");
            }

            foreach (KeyValuePair<int,string> item in DictionaryList)
            {
                Console.WriteLine("Key : {0}  || Value : {1}",item.Key, item.Value);
            }

            DictionaryList.Clear(); // Clears the DictonaryList | Sözlük Listesini temizler

            /*
             * SortedList<Tkey, TValue>
             * 
             * The SortedList<TKey, TValue>, and SortedList are collection classes that can store key-value pairs 
             * that are sorted by the keys based on the associated IComparer implementation.
             * For example, if the keys are of primitive types, then sorted in ascending order of keys.
             * 
             * C# supports generic and non-generic SortedList. It is recommended to use generic SortedList<TKey, TValue> 
             * because it performs faster and less error-prone than the non-generic SortedList.
             * 
             * SortedList Characteristics
             * - SortedList<TKey, TValue> is an array of key-value pairs sorted by keys.
             * - Sorts elements as soon as they are added. Sorts primitive type keys in ascending order and object keys based on IComparer<T>.
             * Comes under System.Collection.Generic namespace.
             * A key must be unique and cannot be null.
             * A value can be null or duplicate.
             * A value can be accessed by passing associated key in the indexer mySortedList[key]
             * Contains elements of type KeyValuePair<TKey, TValue>
             * It uses less memory than SortedDictionary<TKey,TValue>.
             * It is faster in the retrieval of data once sorted, whereas SortedDictionary<TKey, TValue> is faster in insertion and removing key-value pairs.
             * 
             * SortedList<TKey, TValue> ve SortedList, ilişkili IComparer uygulamasına göre anahtarlara göre sıralanan 
             * anahtar-değer çiftlerini depolayabilen koleksiyon sınıflarıdır. Örneğin, anahtarlar ilkel türlerdeyse, 
             * artan anahtar sırasına göre sıralanır.
             * 
             * C#, genel ve genel olmayan SortedList'i destekler.
             * Genel SortedList<TKey, TValue> kullanılması önerilir, çünkü genel olmayan SortedList'ten daha hızlı ve hataya daha az eğilimlidir.
             * 
             * SortedList Özellikleri
             * - SortedList<TKey, TValue>, anahtarlara göre sıralanmış bir anahtar-değer çiftleri dizisidir.
             * - Öğeleri eklenir eklenmez sıralar.
             * - İlkel tip anahtarları artan düzende ve nesne anahtarlarını IComparer<T>'ye göre sıralar.
             * - System.Collection.Generic ad alanı altında gelir.
             * - Bir anahtar benzersiz olmalıdır ve boş olamaz.
             * - Bir değer boş olabilir veya yinelenebilir.
             * - Bir değere, mySortedList[key] dizin oluşturucusunda ilgili anahtarı geçirerek erişilebilir.
             * - KeyValuePair<TKey, TValue> türündeki öğeleri içerir
             * - SortedDictionary<TKey,TValue>'dan daha az bellek kullanır.
             * - Sıralandıktan sonra verilerin alınmasında daha hızlıdır, SortedDictionary<TKey, TValue> ise anahtar/değer çiftlerini ekleme ve kaldırmada daha hızlıdır.
             */

            // Creating a SortedList 
            // SortedList of int keys, string values
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");

            //The following will throw exceptions
            //numberNames.Add("Three", 3); //Compile-time error: key must be int type
            //numberNames.Add(1, "One"); //Run-time exception: duplicate key
            //numberNames.Add(null, "Five");//Run-time exception: key cannot be null

            //Creating a SortedList of string keys, string values 
            //using collection-initializer syntax
            SortedList<string, string> cities = new SortedList<string, string>()
                                    {
                                        {"London", "UK"},
                                        {"New York", "USA"},
                                        { "Mumbai", "India"},
                                        {"Johannesburg", "South Africa"}
                                    };

            // Accessing SortedList
            // Specify a key in the indexer sortedList[key], to get or set a value in the SortedList.
            SortedList<int, string> numbersAndNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };

            Console.WriteLine(numbersAndNames[1]); //output: One
            Console.WriteLine(numbersAndNames[2]); //output: Two
            Console.WriteLine(numbersAndNames[3]); //output: Three
                                                   //Console.WriteLine(numberNames[10]); //run-time KeyNotFoundException

            numbersAndNames[2] = "TWO"; //updates value
            numbersAndNames[4] = "Four"; //adds a new key-value if a key does not exists

            // Remove Elements
            numberNames.Remove(1);//removes key 1 pair
            numberNames.Remove(10);//removes key 1 pair, no error if not exists

            numberNames.RemoveAt(0);//removes key-value pair from index 0 
                                    //numberNames.RemoveAt(10);//run-time exception: ArgumentOutOfRangeException

            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);


        }
    }
}
