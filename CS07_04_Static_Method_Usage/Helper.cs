namespace CS07_04_Static_Method_Usage;

// Static Classes can not be instantiated. Helper H1 = new Helper(); cant use.
// Static Classlar örneklenemez. Helper H1 = new Helper(); kullanılamaz.
public static class Helper
{
    // Static Method for send an Email
    public static void sendEmail(string recipientEmail, string subject, string content)
    {
        // Email send process will contuniue....
        // Email gönderme işlemleri devam edecek...
        Console.WriteLine("Mail Sent!");
        Console.WriteLine("Mail Gönderildi!");
    }
}