namespace CS05_01_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# - What is OOP?
             *
             * OOP stands for Object-Oriented Programming.
             *
             * Procedural programming is about writing procedures or methods that perform operations on the data,
             * while object-oriented programming is about creating objects that contain both data and methods.
             *
             * Object-oriented programming has several advantages over procedural programming:
             *
             *  - OOP is faster and easier to execute
             *  - OOP provides a clear structure for the programs
             *  - OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain,
             * modify and debug
             *  - OOP makes it possible to create full reusable applications with less code and shorter development time
             *
             * Tip: The "Don't Repeat Yourself" (DRY) principle is about reducing the repetition of code.
             * You should extract out the codes that are common for the application, and place them at a single place
             * and reuse them instead of repeating it.
             *
             *
             * C# - OOP nedir?
             *
             * OOP, Nesne Yönelimli Programlama anlamına gelir.
             *
             * Prosedürel programlama, veriler üzerinde işlem gerçekleştiren prosedürler veya yöntemler yazmakla
             * ilgiliyken, nesne yönelimli programlama hem verileri hem de yöntemleri içeren nesneler oluşturmakla ilgilidir.
             *
             * Nesne yönelimli programlamanın prosedürel programlamaya göre birçok avantajı vardır:
             *  - OOP daha hızlı ve yürütülmesi daha kolay
             *  - OOP, programlar için net bir yapı sağlar
             *  - OOP, C# kodunu DRY "Kendinizi Tekrar Etmeyin" tutmaya yardımcı olur ve kodun bakımını,
             * değiştirilmesini ve hata ayıklamasını kolaylaştırır
             *  - OOP, daha az kod ve daha kısa geliştirme süresi ile tam yeniden kullanılabilir uygulamalar
             * oluşturmayı mümkün kılar
             *
             * İpucu: "Kendini Tekrar Etme" (DRY) ilkesi, kod tekrarını azaltmakla ilgilidir.
             * Uygulama için ortak olan kodları çıkarıp tek bir yere yerleştirmeli ve tekrarlamak yerine
             * tekrar kullanmalıyız.
             */
            /*
             * ***** o ***** Classes (Sınıflar) & Objects (Nesneler) ***** o *****
             *
             *  - Class is a template/blueprint, where we define variable and methods
             *  - Sınıf, değişken ve metodları tanımladığımız bir şablon/plan/ iskelettir.
             *
             *  - Objects are the instances of the class. Each object will have its own copy
             * of variables.
             *  - Nesneler(Objects) sınıfın(class) örnekleridir. Her nesne kendi değişken(variable)
             * kopyalarına sahip olur.
             *
             *
             * ***** o ***** Constructors (Yapıcılar/Oluşturucular) ***** o *****
             *
             *  - A constructor is a method that is automatically called when an object is
             * created.
             *  - Yapıcı(Constructor), bir nesne yaratıldığında otomatik olarak çağrılan bir metoddur.
             *
             *  - Constructors are used to initialize the object’s instance fields.
             *  - Yapıcılar(Constructors), nesnenin örnek/misal(Instance) alanlarını başlatmak için kullanılır
             *
             *  - They are called constructor because the help construct an object.
             *  - Yardım bir nesne oluşturduğu için yapıcı olarak adlandırılırlar.
	         *
             *  - new keyword invokes the constructor of the class.
             *  - new anahtar sözcüğü, sınıfın yapıcısını çağırır.
             *
             * ***** o ***** Creating Constructors ***** o *****
             *
             *  - Constructor is a special method that matches the name of the class and has no return type.
             *  - Constructor, sınıfın adıyla eşleşen ve dönüş türü olmayan özel bir yöntemdir.
             *
             * ***** o ***** Types of Constructors ***** o *****
             *
             *  - No-argument Constructor: A constructor that has no parameter is known as
             * default constructor. If we do not define a constructor in a class, then
             * compiler creates default constructor(with no argument) for the class. If we
             * write a constructor with arguments or no-arguments then the compiler does not
             * create a default constructor. Default constructor provides the default values
             * to object like 0, null, etc. depending on the type.
             *
             *  - Argümansız Oluşturucu: Parametresi olmayan bir yapıcı, varsayılan yapıcı olarak bilinir.
             * Bir sınıfta bir kurucu tanımlamazsak, derleyici sınıf için varsayılan kurucu (argümansız) oluşturur.
             * Argümanlı veya argümansız bir kurucu yazarsak, derleyici varsayılan bir kurucu oluşturmaz.
             * Varsayılan yapıcı, türe bağlı olarak 0, null vb. gibi nesneye varsayılan değerler sağlar.
             *
             *  - Parameterized Constructor: A constructor that has parameters is known as
             * parameterized constructor. If we want to initialize fields of the class with
             * your own values, then use parameterized constructor.
             *
             *  - Parametreli Oluşturucu: Parametreleri olan bir yapıcı, parametreli yapıcı olarak bilinir.
             * Sınıfın alanlarını kendi değerlerinizle başlatmak istiyorsak, parametreli yapıcıyı kullanırız.
             *
             *
             * ***** o ***** this Keyword ***** o *****
             *
             *  - 
             *
             *
             * ***** o ***** Constructors Overloading ***** o *****
             *
             *  - Like methods, we can overload constructors for creating objects in
             * different ways. Compiler differentiates constructors on the basis of numbers
             * of parameters, types of the parameters and order of the parameters.
             *
             *  - Yöntemler gibi, nesneler oluşturmak için yapıcıları farklı şekillerde aşırı yükleyebiliriz.
             * Derleyici, yapıcıları parametre sayılarına, parametre türlerine ve parametrelerin sırasına göre ayırır.
             *
             *
             * ***** o ***** Constructors Chaining ***** o *****
             *
             *  - Constructor chaining is the process of calling one constructor from another
             * constructor with respect to current object.
             *
             *  - Yapıcı zincirleme, mevcut nesneye göre bir kurucuyu başka bir kurucudan çağırma işlemidir.
             *
             *  - Chaining can be done using this() keyword.
             *  - Zincirleme this() anahtar kelimesi kullanılarak yapılabilir.
             *
             *  - this() keyword should always be the first line of the constructor.
             *  - this() anahtar sözcüğü her zaman yapıcının ilk satırı olmalıdır.
             *
             * ***** o ***** Difference Between Constructors and Methods ***** o *****
             *
             * • Constructor •
             *
             *  - A constructor is used to initialize the variables of a Class
             *  - Bir Sınıfın değişkenlerini başlatmak için bir kurucu kullanılır
             *
             *  - A constructor must not have return type
             *  - Bir kurucu dönüş tipine sahip olmamalıdır
             *
             *  - The constructor has invoked automatically at the time of object creation.
             *  - Yapıcı, nesne oluşturma sırasında otomatik olarak çağrılır.
             * 
             *  - Constructors can be called explicitly when there are multiple constructors
             * are defined.
             *  - Birden çok kurucu tanımlandığında, yapıcılar açıkça çağrılabilir.
             *
             *  - The compiler provides a default constructor if you do not have any
             * constructor
             *  - Herhangi bir kurucunuz yoksa, derleyici varsayılan bir kurucu sağlar.
             *
             *  - Constructor name must be same as the class name
             *  - Yapıcı adı, sınıf adıyla aynı olmalıdır
             *
             *
             * •  Method •
             *
             *  - A method is used to define the behavior/functionalities of an object
             *  - Bir nesnenin davranışını/işlevlerini tanımlamak için bir yöntem kullanılır
             *
             *  - The method may or may not have a return type
             *  - Yöntemin bir dönüş türü olabilir veya olmayabilir
             *
             *  - The method is invoked explicitly using the dot operator
             *  - Yöntem, nokta operatörü kullanılarak açıkça çağrılır
             * 
             *  - There is no existence of default Method
             *  - Varsayılan Yöntemin varlığı yoktur
             *
             *  - Method name may or may not be same as class name
             *  - Yöntem adı, sınıf adıyla aynı olabilir veya olmayabilir
             *
             * ***** o ***** Passing Objects as Arguments ***** o *****
             *
             *  - When an object is passed as an argument to a method, the object’s address
             * is passed into the method’s parameter variable. As a result, the parameter
             * references the object.
             *
             *  - Bir nesne bir yönteme argüman olarak iletildiğinde,
             * nesnenin adresi yöntemin parametre değişkenine iletilir.
             * Sonuç olarak, parametre nesneye başvurur.
             */
        }
    }
}