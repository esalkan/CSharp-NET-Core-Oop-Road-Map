namespace CS01_18_Exercise_02;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Kullanıcıyı selamlama ile karşılayarak, adını, soyadını, şehir bilgisini ve yaşını alarak
         * alınan değerleri ekrana yazdırın.
         *
         * Greet the user with a greeting, take the name, surname, city information and age
         * and print the values on the screen.
         */

        string name, surname, city, age;

        Console.WriteLine("-----> Merhaba / Hello <-----");

        Console.WriteLine("Please Enter Your Name / Lütfen İsminizi Girin :");
        name = Console.ReadLine();

        Console.WriteLine("Please Enter Your Surname / Lütfen Soyadınızı Girin :");
        surname = Console.ReadLine();

        Console.WriteLine("Please Enter Your City / Lütfen Şehrinizi Girin :");
        city = Console.ReadLine();

        Console.WriteLine("Please Enter Your Age / Lütfen Yaşınızı Girin :");
        age = Console.ReadLine();
        var ageInput = Convert.ToInt32(age);

        Console.Clear();

        Console.WriteLine($"Name / İsim : {name}");
        Console.WriteLine($"Surname / Soyisim : {surname}");
        Console.WriteLine($"City / Şehir : {city}");
        Console.WriteLine($"Age / Yaş : {ageInput}");
    }
}