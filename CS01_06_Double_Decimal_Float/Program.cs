namespace CS01_06_Double_Decimal_Float
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Double, Decimal, Float

            // Double Data Type
            Console.WriteLine("-----> Double <-----");
            double doubleVal1 = 10.2;
            double doubleVal2 = 10;
            double doubleVal3 = 10.5d; // d is not mandatory for double data type
            double doubleMaxVal = double.MaxValue;
            double doubleMinVal = double.MinValue;
            Console.WriteLine($"doubleVal1 is : {doubleVal1}");
            Console.WriteLine($"doubleVal2 is : {doubleVal2}");
            Console.WriteLine($"doubleVal3 is : {doubleVal3}");
            Console.WriteLine($"doubleMaxVal is : {doubleMaxVal}");
            Console.WriteLine($"doubleMinVal is : {doubleMinVal}");

            // Decimal
            Console.WriteLine("-----> Decimal <-----");
            decimal decimalVal1 = 10.2M; // M or m is mandatory for decimal data type
            decimal decimalMinVal = decimal.MinValue;
            decimal decimalMaxVal = decimal.MaxValue;
            Console.WriteLine($"decimalVal1 is : {decimalVal1}");
            Console.WriteLine($"decimalMinVal is : {decimalMinVal}");
            Console.WriteLine($"decimalMaxVal is : {decimalMaxVal}");

            // Float
            Console.WriteLine("-----> Float <-----");
            float floatVal1 = 10.5F; // F is mandatory for float data types
            float floatMaxVal = float.MaxValue;
            float floatMinVal = float.MinValue;
            Console.WriteLine($"floatVal1 is : {floatVal1}");
            Console.WriteLine($"floatMaxVal is : {floatMaxVal}");
            Console.WriteLine($"floatMinVal is : {floatMinVal}");

            #endregion

            Console.ReadKey();
        }
    }
}