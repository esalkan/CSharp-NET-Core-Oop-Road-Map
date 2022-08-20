namespace CS03_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Collection classes are specialized classes for data storage and retrieval.
             * These classes provide support for stacks, queues, lists, and hash tables.
             * Most collection classes implement the same interfaces.
             *
             * Collection classes serve various purposes, such as allocating memory dynamically to elements and
             * accessing a list of items on the basis of an index etc. These classes create collections of
             * objects of the Object class, which is the base class for all data types in C#.
             *
             * Various Collection Classes and Their Usage
             * The following are the various commonly used classes of the System.Collection namespace.
             *
             * 1- ArrayList
             * It represents ordered collection of an object that can be indexed individually.
             *
             * It is basically an alternative to an array. However, unlike array we can add and remove items
             * from a list at a specified position using an index and the array resizes itself automatically.
             * It also allows dynamic memory allocation, adding, searching and sorting items in the list.
             *
             * 2- Hashtable
             * It uses a key to access the elements in the collection.
             *
             * A hash table is used when we need to access elements by using key, and we can identify a useful key value.
             * Each item in the hash table has a key/value pair. The key is used to access the items in the collection.
             *
             * 3- SortedList
             * It uses a key as well as an index to access the items in a list.
             *
             * A sorted list is a combination of an array and a hash table.
             * It contains a list of items that can be accessed using a key or an index.
             * If we access items using an index, it is an ArrayList, and if we access items using a key ,
             * it is a Hashtable. The collection of items is always sorted by the key value.
             *
             * 4- Stack
             * It represents a last-in, first out collection of object.
             * It is used when we need a last-in, first-out access of items.
             * When we add an item in the list, it is called pushing the item and when we remove it, it is called popping the item.
             *
             * 5- Queue
             * It represents a first-in, first out collection of object.
             * It is used when we need a first-in, first-out access of items.
             * When we add an item in the list, it is called enqueue and when we remove an item, it is called deque.
             *
             * 6- BitArray
             * It represents an array of the binary representation using the values 1 and 0.
             *
             * It is used when we need to store the bits but do not know the number of bits in advance.
             * We can access items from the BitArray collection by using an integer index, which starts from zero.
             */
            
            /*
             * Koleksiyon sınıfları, veri depolama ve alma için özel sınıflardır.
             * Bu sınıflar yığınlar, kuyruklar, listeler ve karma tablolar için destek sağlar.
             * Çoğu koleksiyon sınıfı aynı arabirimleri uygular.
             *
             * Koleksiyon sınıfları, öğelere dinamik olarak bellek ayırmak ve bir dizin temelinde bir öğe listesine
             * erişmek gibi çeşitli amaçlara hizmet eder.
             * Bu sınıflar, C#'daki tüm veri türleri için temel sınıf olan Object sınıfının nesne koleksiyonlarını oluşturur.
             *
             * Çeşitli Koleksiyon Sınıfları ve Kullanımları
             * Aşağıdakiler, System.Collection ad alanının yaygın olarak kullanılan çeşitli sınıflarıdır.
             *
             * 1- ArrayList
             * Tek tek dizine eklenebilen bir nesnenin sıralı koleksiyonunu temsil eder.
             *
             * Temelde bir diziye bir alternatiftir. Ancak, diziden farklı olarak, bir dizin kullanarak
             * belirli bir konumda bir listeden öğeler ekleyebilir ve kaldırabiliriz ve dizi kendini otomatik olarak
             * yeniden boyutlandırır. Ayrıca listedeki öğeleri dinamik bellek ayırma, ekleme, arama ve sıralama sağlar.
             *
             * 2- Hashtable
             * Koleksiyondaki öğelere erişmek için bir anahtar kullanır.
             *
             * Anahtar kullanarak öğelere erişmemiz gerektiğinde bir karma tablo kullanılır ve yararlı bir anahtar
             * değeri belirleyebiliriz. Karma tablodaki her öğenin bir anahtar/değer çifti vardır.
             * Anahtar, koleksiyondaki öğelere erişmek için kullanılır.
             *
             * 3- Sıralı Liste
             * Listedeki öğelere erişmek için bir anahtarın yanı sıra bir dizin kullanır.
             *
             * Sıralanmış bir liste, bir dizi ve bir karma tablonun birleşimidir.
             * Bir anahtar veya dizin kullanılarak erişilebilen öğelerin bir listesini içerir.
             * Öğelere bir dizin kullanarak erişirsek, bu bir ArrayList'tir ve öğelere bir anahtar kullanarak erişirsek,
             * bir Hashtable'dır. Öğe koleksiyonu her zaman anahtar değerine göre sıralanır.
             *
             * 4- Stack
             * Son giren ilk çıkar nesne koleksiyonunu temsil eder.
             *
             * Öğelerin son giren ilk çıkar erişimine ihtiyacımız olduğunda kullanılır.
             * Listeye bir madde eklediğimizde eşyayı itmek, çıkardığımızda eşyayı patlatmak olarak adlandırılır.
             *
             * 5- Queue
             * İlk giren ilk çıkar nesne koleksiyonunu temsil eder.
             *
             * Öğelerin ilk giren ilk çıkar erişimine ihtiyacımız olduğunda kullanılır.
             * Listeye bir öğe eklediğimizde buna enqueue, bir öğeyi kaldırdığımızda ise deque denir.
             *
             * 6- BitArray
             * 1 ve 0 değerlerini kullanarak ikili gösterimin bir dizisini temsil eder.
             *
             * Bitleri saklamamız gerektiğinde ancak bit sayısını önceden bilmediğimizde kullanılır.
             * sıfırdan başlayan bir tamsayı dizini kullanarak BitArray koleksiyonundaki öğelere erişebiliriz.
             */
        }
    }
}