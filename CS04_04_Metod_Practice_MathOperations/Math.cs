namespace CS04_04_Metod_Practice_MathOperations;

public class Math
{
    // Addition | Toplama İşlemi
    public decimal Addition(decimal num1, decimal num2)
    {
        decimal result = num1 + num2;
        return result;
    }
    
    // Subtraction | Çıkartma İşlemi
    public decimal Subtraction(decimal num1, decimal num2)
    {
        decimal result = num1 - num2;
        return result;
    }
    
    // Multiplication | Çarpma İşlemi
    public decimal Multiplication(decimal num1, decimal num2)
    {
        decimal result = num1 * num2;
        return result;
    }
    
    // Division | Bölme İşlemi
    public decimal Division(decimal num1, decimal num2)
    {
        decimal result = num1 / num2;
        return result;
    }

    public void FourOperationMenus()
    {
        Console.Clear();
        Console.WriteLine("-----> Menu <-----");
        Console.WriteLine("1- Addition | Toplama İşlemi");
        Console.WriteLine("2- Subtraction | Çıkartma İşlemi");
        Console.WriteLine("3- Multiplication | Çarpma İşlemi");
        Console.WriteLine("4- Division | Bölme İşlemi");
        Console.WriteLine("\nPlease make your selection : ");
    }

    public void resultOutput(decimal num1, string operators, decimal num2, decimal result)
    {
        Console.WriteLine($"{num1} {operators} {num2} = {result}");
    }
}