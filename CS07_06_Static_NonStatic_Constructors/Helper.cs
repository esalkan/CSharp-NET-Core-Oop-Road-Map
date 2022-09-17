namespace CS07_06_Static_NonStatic_Constructors;

// Static Classes can not be instantiated. Helper H1 = new Helper(); cant use.
// Static Classlar örneklenemez. Helper H1 = new Helper(); kullanılamaz.
public static class Helper
{
    // -----------------------------------------------------------------------------------------------------------------

    // NON-STATIC FIELD/PROPERTY CANNOT BE CONTAINED IN STATIC CLASSES.
    // STATIC CLASSLARIN ICERISINDE STATIC OLMAYAN ALANLAR/PROPERTY BULUNAMAZ.
    // public string Subject { get; set; }

    // -----------------------------------------------------------------------------------------------------------------

    // NON-STATIC METHODS CANNOT BE CONTAINED STATIC CLASSES.
    // STATIC CLASSLARIN ICERISINDE STATIC OLMAYAN METODLAR BULUNAMAZ
    // public void Test()
    // {
    //    Console.WriteLine("Test 1");
    // }

    // -----------------------------------------------------------------------------------------------------------------

    
    // CONSTRUCTOR METHOD
    
    // NON-STATIC CONSTRUCTORS CAN NOT BE CONTAINED IN STATIC CLASSES.
    // STATIC OLMAYAN CONSTRUCTORLAR STATIC CLASS ICERISINDE YER ALAMAZLAR
    // public Helper() {} // Her nesne örneği oluşturulduğunda uygulama standart yapıcı/constructor metodu çağırır
                          // The application calls the standard constructor method every time an object instance is created
    static Helper()
    {
        // STATIC CONSTRUCTOR
        // Uygulama içerisinde istenildiği kadar çağırılsada sadece ilk çağırılmada çalışırlar...
        // Even if they are called as many times as desired in the application, they only work on the first call...
        Console.WriteLine("Helper.cs => Static Class => Static Constructor");
        Console.WriteLine();
    }
    
    // Static Method for send an Email
    public static void sendEmail(string recipientEmail, string subject, string content)
    {
        // Email send process will contuniue....
        // Email gönderme işlemleri devam edecek...
        Console.WriteLine("Mail Sent!");
        Console.WriteLine("Mail Gönderildi!");
        Console.WriteLine();
    }
}