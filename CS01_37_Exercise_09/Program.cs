namespace CS01_37_Exercise_09;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Menu | Menü
         * 1- Addition | Toplama
         * 2- Subtract | Çıkartma
         * 3- Multiply | Çarpma
         * 4- Divide | Bölme
         *
         * Please, Make a selection :
         * Lütfen, bir seçim yapın :
         *
         * Rules : 4 seçenek içerisinde bölen 0 olamaz kontrolü yapılacak
         */

        var menu =
            "Menu | Menü\n1- Addition | Toplama\n2 - Subtract | Çıkartma\n3 - Multiply | Çarpma\n4 - Divide | Bölme";
        var selection = "Please, Make a selection :\nLütfen, bir seçim  yapın :";
        string selectedOption;
        double num1, num2;
        double result;

        Console.WriteLine(menu);
        Console.WriteLine(selection);
        selectedOption = Console.ReadLine();

        Console.WriteLine("Enter first number :\nİlk sayınızı girin:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number :\nİkinci sayınızı girin:");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Clear();

        if (selectedOption == "4" && num2 == 0)
        {
            Console.WriteLine("Divisor can not be 0.");
            Console.WriteLine("Bölen 0 olamaz.");
        }
        else
        {
            switch (selectedOption)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"Addition result | Toplama sonucu : {result}");
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Subtract result | Çıkartma sonucu  : {result}");
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Multiply result | Çarpma sonucu : {result}");
                    break;
                case "4":
                    result = num1 / num2;
                    Console.WriteLine($"Divide result | Bölme sonucu : {result}");
                    break;
            }
        }
    }
}