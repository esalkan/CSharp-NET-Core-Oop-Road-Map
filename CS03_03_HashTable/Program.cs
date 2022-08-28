using System;
using System.Collections;
using System.Collections.Specialized;

namespace CS03_03_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2- Hashtable
             * It uses a key to access the elements in the collection.
             *
             * A hash table is used when we need to access elements by using key, and we can identify a useful key value.
             * Each item in the hash table has a key/value pair. The key is used to access the items in the collection.
             *
             * ---------------------------------------------------------------------------------------------------------
             * 
             * 2- Hashtable
             * Koleksiyondaki öğelere erişmek için bir anahtar kullanır.
             *
             * Anahtar kullanarak öğelere erişmemiz gerektiğinde bir karma tablo kullanılır ve yararlı bir anahtar
             * değeri belirleyebiliriz. Karma tablodaki her öğenin bir anahtar/değer çifti vardır.
             * Anahtar, koleksiyondaki öğelere erişmek için kullanılır.
             *
             * ---------------------------------------------------------------------------------------------------------
             * 
             * The Hashtable class represents a collection of key-and-value pairs that are organized based on the hash
             * code of the key. It uses the key to access the elements in the collection.
             *
             * A hash table is used when you need to access elements by using key, and you can identify a useful
             * key value. Each item in the hash table has a key/value pair. The key is used to access the items
             * in the collection.
             *
             * ---------------------------------------------------------------------------------------------------------
             * 
             * Hashtable sınıfı, anahtarın karma koduna dayalı olarak düzenlenen bir anahtar ve değer çiftleri
             * koleksiyonunu temsil eder. Koleksiyondaki öğelere erişmek için anahtarı kullanır.
             *
             * Anahtarı kullanarak öğelere erişmeniz gerektiğinde bir karma tablo kullanılır ve kullanışlı bir anahtar
             * değeri tanımlayabilirsiniz. Karma tablodaki her öğenin bir anahtar/değer çifti vardır.
             * Anahtar, koleksiyondaki öğelere erişmek için kullanılır.
             *
             *  PROPERTIES
             *      -> Count
             *      -> EqualityComparer
             *      -> IsFixedSize
             *      -> IsReadOnly
             *      -> IsSynchronized
             *      -> Item[]
             *      -> Keys
             *      -> SyncRoot
             *      -> Values
             *
             *  METHODS
             *      -> Add
             *      -> Clear
             *      -> Clone
             *      -> Contains
             *      -> ContainsKey
             *      -> ContainsValue
             *      -> CopyTo
             *      -> GetEnumerator
             *      -> GetHash
             *      -> GetObjectData
             *      -> KeyEquals
             *      -> OnDeserialization
             *      -> Remove
             *      -> Synchronized
             */

            Hashtable ht = new Hashtable();
            
            ht.Add("001", "Ebede");
            ht.Add("002", "Albastı");
            ht.Add("003", "Arçura");
            ht.Add("004", "Yelbegen");
            ht.Add("005", "Tepegöz");
            ht.Add("006", "Merküt");
            ht.Add("007", "Abray");
            ht.Add("008", "Ayasu");
            ht.Add("009", "Ceren");
            ht.Add("010", "Payna");

            #region Count
            Console.WriteLine("-----> Count <-----");
            // Count
            // Gets the number of key/value pairs contained in the Hashtable.
            // Hashtable'da bulunan anahtar/değer çiftlerinin sayısını alır.
            Console.WriteLine(ht.Count);
            #endregion
            
            #region EqualityComparer
            Console.WriteLine("\n-----> EqualityComparer <-----");
            // EqualityComparer
            // Gets the IEqualityComparer to use for the Hashtable.
            // Hashtable için kullanılacak IEqualityComparer'ı alır.
            #endregion
            
            #region IsFixedSize
            Console.WriteLine("\n-----> IsFixedSize <-----");
            // IsFixedSize
            // Gets a value indicating whether the Hashtable has a fixed size.
            // Hashtable'ın sabit bir boyutu olup olmadığını gösteren bir değer alır.
            Console.WriteLine(ht.IsFixedSize);
            #endregion
            
            #region IsReadOnly
            Console.WriteLine("\n-----> IsReadOnly <-----");
            // IsReadOnly
            // Gets a value indicating whether the Hashtable is read-only.
            // Hashtable'ın salt okunur olup olmadığını gösteren bir değer alır.
            Console.WriteLine(ht.IsReadOnly);
            #endregion
            
            #region IsSynchronized
            Console.WriteLine("\n-----> IsSynchronized <-----");
            // IsSynchronized
            // Gets a value indicating whether access to the Hashtable is synchronized (thread safe).
            // Hashtable'a erişimin senkronize edilip edilmediğini gösteren bir değer alır (iş parçacığı güvenli).
            Console.WriteLine(ht.IsSynchronized);
            #endregion
            
            #region Item[]
            Console.WriteLine("\n-----> Item[] <-----");
            // Item[]
            // Gets or sets the value associated with the specified key.
            // Belirtilen anahtarla ilişkili değeri alır veya ayarlar.
            Console.WriteLine(ht["001"]);
            #endregion
            
            #region Keys
            Console.WriteLine("\n-----> Keys <-----");
            // Keys
            // Gets an ICollection containing the keys in the Hashtable.
            // List keys un-ordered.
            // Hashtable'daki anahtarları içeren bir ICollection alır.
            // Düzensiz bir şekilde listeler.
            foreach (var key in ht.Keys)
            {
                Console.Write(key + " " );
            }
            #endregion
            
            #region SyncRoot
            Console.WriteLine("\n-----> SyncRoot <-----");
            // SyncRoot
            // Gets an object that can be used to synchronize access to the Hashtable.
            // Hashtable'a erişimi senkronize etmek için kullanılabilecek bir nesne alır.
            #endregion
            
            #region Values
            Console.WriteLine("\n-----> Values <-----");
            // Values
            // Gets an ICollection containing the values in the Hashtable.
            // Hashtable'daki değerleri içeren bir ICollection alır.
            foreach (var value in ht.Values)
            {
                Console.Write(value + " ");
            }
            #endregion
            
            #region Add
            Console.WriteLine("\n-----> Add <-----");
            // Add
            // Adds an element with the specified key and value into the Hashtable.
            // Hashtable'a belirtilen anahtar ve değere sahip bir öğe ekler.
            ht.Add("000", "Emin");
            #endregion
            
            #region Clear
            Console.WriteLine("\n-----> Clear <-----");
            // Clear
            // Removes all elements from the Hashtable.
            // Hashtable'dan tüm öğeleri kaldırır.
            #endregion
            
            #region Clone
            Console.WriteLine("\n-----> Clone <-----");
            // Clone
            // Creates a shallow copy of the Hashtable.
            // Hashtable'ın sığ bir kopyasını oluşturur.
            object newHt = ht.Clone();
            Console.WriteLine(newHt.ToString());
            #endregion
            
            #region Contains
            Console.WriteLine("\n-----> Contains <-----");
            // Contains
            // Determines whether the Hashtable contains a specific key.
            // Hashtable'ın belirli bir anahtar içerip içermediğini belirler.
            Console.WriteLine(ht.Contains("000"));
            #endregion
            
            #region ContainsKey
            Console.WriteLine("\n-----> ContainsKey <-----");
            // ContainsKey
            // Determines whether the Hashtable contains a specific key.
            // Hashtable'ın belirli bir anahtar içerip içermediğini belirler.
            Console.WriteLine(ht.ContainsKey("001"));
            #endregion
            
            #region ContainsValue
            Console.WriteLine("\n-----> ContainsValue <-----");
            // ContainsValue
            // Determines whether the Hashtable contains a specific value.
            // Hashtable'ın belirli bir değer içerip içermediğini belirler.
            Console.WriteLine(ht.ContainsValue("Emin"));
            #endregion
            
            #region CopyTo
            Console.WriteLine("\n-----> CopyTo <-----");
            // CopyTo
            // Copies the Hashtable elements to a one-dimensional Array instance at the specified index.
            // Hashtable öğelerini belirtilen dizinde tek boyutlu bir Array örneğine kopyalar.
            #endregion
            
            #region GetEnumerator
            Console.WriteLine("\n-----> GetEnumerator <-----");
            // GetEnumerator
            // Returns an IDictionaryEnumerator that iterates through the Hashtable.
            // Hashtable aracılığıyla yinelenen bir IDictionaryEnumerator döndürür.
            #endregion
            
            #region GetHash(Object) 
            Console.WriteLine("\n-----> GetHash(Object)  <-----");
            // GetHash(Object) 
            // Returns the hash code for the specified key.
            // Belirtilen anahtarın karma kodunu döndürür.
            Console.WriteLine(ht.GetHashCode());
            #endregion
            
            #region GetObjectData(SerializationInfo, StreamingContext)
            Console.WriteLine("\n-----> GetObjectData(SerializationInfo, StreamingContext) <-----");
            // GetObjectData(SerializationInfo, StreamingContext)
            // Implements the ISerializable interface and returns the data needed to serialize the Hashtable.
            // ISerializable arabirimini uygular ve Hashtable'ı seri hale getirmek için gereken verileri döndürür.
            #endregion
            
            #region KeyEquals(Object, Object)
            Console.WriteLine("\n-----> KeyEquals(Object, Object) <-----");
            // KeyEquals(Object, Object)
            // Compares a specific Object with a specific key in the Hashtable.
            // Hashtable'da belirli bir Nesneyi belirli bir anahtarla karşılaştırır.
            #endregion
            
            #region OnDeserialization(Object)
            Console.WriteLine("\n-----> OnDeserialization(Object) <-----");
            // OnDeserialization(Object)
            // Implements the ISerializable interface and raises the deserialization event when the deserialization is complete.
            // ISerializable arabirimini uygular ve seri durumdan çıkarma tamamlandığında seri durumdan çıkarma olayını başlatır.
            #endregion
            
            #region Remove(Object)
            Console.WriteLine("\n-----> Remove(Object) <-----");
            // Remove(Object)
            // Removes the element with the specified key from the Hashtable.
            // Belirtilen anahtara sahip öğeyi Hashtable'dan kaldırır.
            #endregion

            #region Synchronized(Hashtable)
            Console.WriteLine("-----> Synchronized(Hashtable) <-----");
            // Synchronized(Hashtable)
            // Returns a synchronized (thread-safe) wrapper for the Hashtable.
            // Hashtable için eşitlenmiş (iş parçacığı için güvenli) bir sarmalayıcı döndürür.
            #endregion

            #region Example Question & Answer

            Console.WriteLine("İngilizce | Türkçe Sözlük.");
            Hashtable dictionaryDB = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("Eklemek istediğiniz ingilizce kelimeyi yazınız.\nType the English word you want to add.");
                Console.WriteLine("EN : ");
                string eng = Console.ReadLine();

                bool control = dictionaryDB.ContainsKey(eng);
                if (control)
                {
                    Console.WriteLine($"Eklemek istediğiniz kelime '{eng}' sözlük içerisinde mevcuttur.\n'{dictionaryDB[eng].ToString()}' türkçe karşılığıdır.");
                    Console.WriteLine($"The word you want to add '{eng}' is available in the dictionary.\n'{dictionaryDB[eng].ToString()}' is the Turkish equivalent.");
                }
                else
                {
                    Console.WriteLine("TR : ");
                    string tr = Console.ReadLine();
                    dictionaryDB.Add(eng,tr);
                    Console.WriteLine("Ekleme işlemi başarılı! | The insertion was successful!");
                }

                Console.WriteLine("Yeni kelime eklemek istiyor musunuz? (Y/N) | Do you want to add new word? (Y/N)");
            } while (Console.ReadLine().ToUpper() == "Y");

            foreach (var item in dictionaryDB.Keys)
            {
                Console.WriteLine($"Eng : {item}\nTr : {dictionaryDB[item]}\n");
            }

            foreach (DictionaryEntry item in dictionaryDB)
            {
                // Console.WriteLine(item.GetType().Name);
                Console.WriteLine($"Eng : {item.Key} - Tr : {item.Value}");
            }
            #endregion

            

        }
    }
}