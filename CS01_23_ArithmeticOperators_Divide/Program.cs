namespace CS01_23_ArithmeticOperators_Divide;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Divide | Bölme
         * Operator : "/"
         */

        var s1 = 10;
        var s2 = 2;
        var result1 = s1 / s2;

        var s3 = 0;
        var result2 = s1 / s3; // System.DivideByZeroException.
    }
}