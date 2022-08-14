namespace CS01_11_Exercise_01;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Kullanıcıdan ad, soyad ve yaşadığı yer bilgilerini alalım.
         * Kullanıcı istenen bilgileri girişini yaptıktan sonra ekranı temizleyelim ve kullanıcıdan alınan verileri ekranda gösterelim.
         *
         * Let's get the name, surname and place of residence from the user.
         * After the user has entered the requested information, let's clear the screen and show the data received from the user on the screen.
         */

        string name, surname, city;
        Console.WriteLine("Please Enter Your Name : ");
        name = Console.ReadLine();
        Console.WriteLine("Please Enter Your Surname : ");
        surname = Console.ReadLine();
        Console.Write("Please Enter Your City : ");
        city = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Your name is : {name}");
        Console.WriteLine($"Your surname is : {surname}");
        Console.WriteLine($"Your city is : {city}");
    }
}