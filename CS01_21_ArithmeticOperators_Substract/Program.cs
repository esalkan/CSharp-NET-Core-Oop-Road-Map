namespace CS01_21_ArithmeticOperators_Substract;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Çıkartma | Substraction (-) Operator
         */

        var num1 = 100;
        var num2 = 50;
        var resultInt = num1 - num2;
        Console.WriteLine("Int substraction result is : " + resultInt);

        byte byt1 = 100;
        byte byt2 = 50;
        var resultByte = byt1 - byt2;
        Console.WriteLine("Byte substraction result is : " + resultByte);
    }
}