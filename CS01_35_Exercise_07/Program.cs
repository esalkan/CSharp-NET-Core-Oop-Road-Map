namespace CS01_35_Exercise_07;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please, Enter your User Name:\nKullanıcı adınızı giriniz :");
        var userName = Console.ReadLine();
        userName.ToLower();

        Console.WriteLine("Please, Enter your password\nŞifrenizi Giriniz :");
        var password = Console.ReadLine();
        password.ToLower();

        // User Name : admin
        // Password : 123

        if (userName == "admin" && password == "123")
        {
            Console.WriteLine("Hello, Welcome!");
            Console.WriteLine("Merhaba, Hoşgeldiniz!");
        }
        else
        {
            Console.WriteLine("Giriş Başarısız!. Lütfen kullanıcı adı ve şifrenizi kontrol ederek tekrar deneyiniz. ");
            Console.WriteLine("Login failed! Please, check your username and password and try again.");
        }
    }
}