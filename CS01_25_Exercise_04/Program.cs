namespace CS01_25_Exercise_04;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Merhaba! | Hello!
         * İsminiz | Your Name :
         * Soyisminiz | Your Surname :
         * Doğum Yılınız | Your Birth Year :
         *
         * Ekranı Temizle | Clear the screen
         *
         * Çıktı | Print
         *  "Merhaba isim + soyisim + yaş + yaşındasınız.
         *  "Hello name + surname + you are + age + years old
         */

        string name, surname, birthYear;
        int age;

        Console.WriteLine("Merhaba! | Hello!");

        Console.WriteLine("İsminiz | Your Name :");
        name = Console.ReadLine();

        Console.WriteLine("Soyisminiz | Your Surname :");
        surname = Console.ReadLine();

        Console.WriteLine("Doğum Yılınız | Your Birth Year :");
        birthYear = Console.ReadLine();

        var currentYear = DateTime.Now.Year;
        age = currentYear - Convert.ToInt32(birthYear);

        Console.Clear();

        Console.WriteLine($"Merhaba {name} {surname}, {age} yaşındasınız.");
        Console.WriteLine($"Hello {name} {surname}, you are {age} years old.");
    }
}