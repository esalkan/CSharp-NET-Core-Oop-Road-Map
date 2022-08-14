namespace CS01_20_ArithmeticOperators_Addition;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Addition Operator
         * Toplama Operatörü
         * "+"
         * int + int 
         */

        var num1 = 10;
        var num2 = 15;
        var resultSum = num1 + num2;
        Console.WriteLine("resultSum" + resultSum);

        byte num3 = 10;
        byte num4 = 10;
        var resultByte = num3 + num4;
        Console.WriteLine("resultByte is : " + resultByte);

        // string   +   int     (string)
        // int      +   string  (string)
        // string   +   string  (string)s
        var str1 = "Hello";
        var resultStr = str1 + num1;
        Console.WriteLine("str1 + num1 : " + str1 + num1);
    }
}