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

        }
    }
}