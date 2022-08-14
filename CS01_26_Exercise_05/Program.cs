namespace CS01_26_Exercise_05;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Kullanıcıdan 2 adet sayı alın ve tüm matematiksel operatör işlemlerini gerçekleştirin.
         * Get 2 numbers from the user and perform all mathematical operator operations.
         *
         * Example :
         *      Sayı 1 Değerini Giriniz | Enter Number 1 Value:
         *      Sayı 2 Değerini Giriniz | Enter Number 2 Value:
         *
         *      +   :
         *      -   :
         *      *   :
         *      '/  :
         *      %   :
         */

        decimal num1, num2;

        Console.WriteLine("Sayı 1 Değerini Giriniz | Enter Number 1 Value:");
        num1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Sayı 2 Değerini Giriniz | Enter Number 2 Value:");
        num2 = Convert.ToDecimal(Console.ReadLine());

        Console.Clear();

        Console.WriteLine($"+ : {num1} + {num2} result is : {num1 + num2}");
        Console.WriteLine($"- : {num1} - {num2} result is : {num1 - num2}");
        Console.WriteLine($"* : {num1} * {num2} result is : {num1 * num2}");
        Console.WriteLine($"/ : {num1} / {num2} result is : {num1 / num2}");
        Console.WriteLine($"+ : {num1} % {num2} result is : {num1 % num2}");
    }
}