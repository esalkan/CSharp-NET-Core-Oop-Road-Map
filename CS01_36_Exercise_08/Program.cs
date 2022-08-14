namespace CS01_36_Exercise_08;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Sistem içerisine giriş yapabilecek kullanıcı kodları:
         * User codes that can login into the system:
         *      ABC - 123 - 236 - CMK
         *      Mesaj   : Kullanıcı girişiniz başarılı.
         *      Message : User login success.
         *
         * Sistem içerisine girişi yasaklanmış kullanıcı kodları:
         * User codes that can not login into the system:
         *      HHH - BBB - MMM
         *      Mesaj   : Kullanıcı girişiniz kilitlenmiştir.
         *      Message : User login locked.
         *
         * Yukarıdaki kodlar dışında ise,
         *      Mesaj   : Hatalı Kullanıcı Kodu!
         *      Message : Wrong user code!
         */

        Console.WriteLine("Please, Enter User Code:\nLütfen, Kullanıcı kodunu giriniz:");
        var userCode = Console.ReadLine();
        userCode.ToUpper();

        if (userCode == "ABC" || userCode == "123" || userCode == "236" || userCode == "CMK")
        {
            Console.WriteLine("Kullanıcı girişiniz başarılı.");
            Console.WriteLine("User login success.");
        }
        else if (userCode == "HHH" || userCode == "BBB" || userCode == "MMM")
        {
            Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir.");
            Console.WriteLine("User login locked.");
        }
        else
        {
            Console.WriteLine("Hatalı Kullanıcı Kodu!");
            Console.WriteLine("Wrong user code!");
        }
    }
}