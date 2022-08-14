namespace CS01_01_ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        // Ekrana kullanıcının görmesini istediğimiz mesajları ya da konsol çıktılarını almak için kullanılır
        // It is used to get the messages or console outputs that we want the user to see on the screen.
        Console.WriteLine("-----> Console.Write() <-----");
        Console.Write("Hello Cruel World! "); // will write on same lime on console
        Console.Write("Maraba Zalım Dunya!"); // with above line code.
        Console.WriteLine(); // will make one line enter like <br>
        Console.WriteLine("-----> Console.WriteLine() <-----");
        Console.Write("Hello Cruel World! "); // will write in one sinle line and put enter one line down
        Console.Write("Maraba Zalım Dunya!"); // will write in one sinle line and put enter one line down
        Console.ReadKey();
    }
}