namespace CS01_06_Double_Decimal_Float;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Double, Decimal, Float

        // Double Data Type
        Console.WriteLine("-----> Double <-----");
        var doubleVal1 = 10.2;
        double doubleVal2 = 10;
        var doubleVal3 = 10.5d; // d is not mandatory for double data type
        var doubleMaxVal = double.MaxValue;
        var doubleMinVal = double.MinValue;
        Console.WriteLine($"doubleVal1 is : {doubleVal1}");
        Console.WriteLine($"doubleVal2 is : {doubleVal2}");
        Console.WriteLine($"doubleVal3 is : {doubleVal3}");
        Console.WriteLine($"doubleMaxVal is : {doubleMaxVal}");
        Console.WriteLine($"doubleMinVal is : {doubleMinVal}");

        // Decimal
        Console.WriteLine("-----> Decimal <-----");
        var decimalVal1 = 10.2M; // M or m is mandatory for decimal data type
        var decimalMinVal = decimal.MinValue;
        var decimalMaxVal = decimal.MaxValue;
        Console.WriteLine($"decimalVal1 is : {decimalVal1}");
        Console.WriteLine($"decimalMinVal is : {decimalMinVal}");
        Console.WriteLine($"decimalMaxVal is : {decimalMaxVal}");

        // Float
        Console.WriteLine("-----> Float <-----");
        var floatVal1 = 10.5F; // F is mandatory for float data types
        var floatMaxVal = float.MaxValue;
        var floatMinVal = float.MinValue;
        Console.WriteLine($"floatVal1 is : {floatVal1}");
        Console.WriteLine($"floatMaxVal is : {floatMaxVal}");
        Console.WriteLine($"floatMinVal is : {floatMinVal}");

        #endregion

        Console.ReadKey();
    }
}