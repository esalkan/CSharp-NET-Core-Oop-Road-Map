namespace CS04_02_Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Main Method
             *
             * The Main method is the entry point of a C# console application or windows application.
             * When the application is started, the Main method is the first method that is invoked.
             * This Main() method is present in every executable application.
             * Executable means any Console application, Windows desktop application or Windows service application.
             *
             * There can only be one entry point in a C# program. If we have more than one class that has a Main method,
             * we must compile our program with the /main compiler option to specify which Main method to use as the entry point.
             * So,
             *  - The Main method is the entry point of an .exe program; it is where the program control starts and ends.
             *  - Main is declared inside a class or struct.
             *  - Main must be static. The enclosing class or struct is not required to be static.
             *  - Main can either have a void or int return type.
             *  - The Main method can be declared with or without a string[] parameter that contains command-line arguments.
             *
             * Main metot, bir C# konsol uygulamasının veya Windows uygulamasının giriş noktasıdır.
             * Uygulama başlatıldığında, çağrılan ilk yöntem Main yöntemidir.
             * Bu Main() yöntemi, her yürütülebilir uygulamada bulunur.
             * Yürütülebilir, herhangi bir Konsol uygulaması, Windows masaüstü uygulaması veya Windows hizmet uygulaması anlamına gelir.
             *
             * Bir C# programında yalnızca bir giriş noktası olabilir. Main yöntemine sahip birden fazla sınıfımız varsa,
             * giriş noktası olarak hangi Main yönteminin kullanılacağını belirtmek için programımızı /main derleyici seçeneğiyle derlemeniz gerekir.
             * Yani,
             *  - Main yöntemi, bir .exe programının giriş noktasıdır; program kontrolünün başladığı ve bittiği yerdir.
             *  - Main, bir sınıf veya yapı içinde bildirilir.
             *  - Main statik olmalıdır. Çevreleyen sınıfın veya yapının statik olması gerekmez.
             *  - Main ya bir void ya da int dönüş tipine sahip olabilir.
             *  - Main yöntemi, komut satırı bağımsız değişkenlerini içeren bir string[] parametresi ile veya onsuz bildirilebilir.
             */
            
            Greetings();
            
            // From Student Class we call that method.
            // Öğrenci sınıfından bu metodu çağırıyoruz.
            Student std1 = new Student();
            std1.GreetingsForStudents();
        }

        public static void Greetings()
        {
            Console.WriteLine("Hello Cruel World! | Merhaba Zalım Dünya!");
        }
    }
}