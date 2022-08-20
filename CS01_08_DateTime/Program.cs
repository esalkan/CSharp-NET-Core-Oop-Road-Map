namespace CS01_DateTime;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1. User working hours 13:00 - 17:00
        // 1. Kullanıcı çalışma saatleri 13:00 - 17:00

        // 2. User working hours 17:00 - 21:00
        // 2. Kullanıcı working hours 17:00 - 21:00

        /*
         * 1. User scan the card
         *      User 1 scanned card inside id is 1
         * 1. User came at 14:00, is user can pass in? = true
         * 2. User came at 14:00, is user can pass in? = false
         */

        Console.WriteLine($"DateTime.Now : {DateTime.Now}");
        Console.WriteLine($"DateTime.Today : {DateTime.Today}");
        Console.WriteLine($"DateTime.MinValue : {DateTime.MinValue}");
        Console.WriteLine($"DateTime.MaxValue : {DateTime.MaxValue}");
        Console.WriteLine($"DateTime.UtcNow : {DateTime.UtcNow}");
    }
}