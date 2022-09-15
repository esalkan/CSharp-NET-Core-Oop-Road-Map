namespace CS07_02_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack bölgede pointer oluşturur.   
            // A pointer has occurred in the stack area.
            WhatIsStatic static1;
            
            // Static bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalışır ve yine class içerisinde
            // tanımlı olan static field, metot static dediğimiz bölgede oluşur.
            // When a pointer is created in the static region, a static constructor method runs and
            // the static field defined in the class is created in the region we call the method static.
            WhatIsStatic.Test2();   // This is a static method.
            Console.WriteLine();
            
            // Stack bölgede pointer => kendisini heap bölgede tamamlar. static olmayan tanımlarını tanımladı.
            static1 = new WhatIsStatic();
            static1.Test1();    // This is non static method.

            Console.WriteLine();
            static1.Name = "ALKAN";
            Console.WriteLine(static1.Name);
            
            
            /*
             * Gerçek hayatta nerelerde kullanulabilir.
             *
             * 1- Helpers.cs => Kontroller için
             * 2- Oluşturmuş olduğumuz nesnemizin => bağımlılığı farklı class lara olduğu için
             * (proje içerisinde özel olduğu için) nesne içerisinde static metot tanımları yapılır.
             * 3- Class içerisinde bir field (static) tanımı yapar ilgili field içerisine bir değer ataması yaparız.
             * Daha sonra uygulama içerisinde "N" farklı yerde oluşturduğumuz static field ımıza ulaşır değerimizi okuruz.
             *
             *
             * Where it can be used in real life.
             *
             * 1- Helpers.cs => For Controls
             * 2- Since the object => we have created is dependent on different classes
             * (since it is private in the project), static method definitions are made in the object.
             * 3- We define a field (static) in the class and assign a value to the related field.
             * Then we reach our static field that we created in "N" different places in the application and read our value.
             */

        }
    }
}