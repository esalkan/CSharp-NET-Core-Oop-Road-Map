namespace CS01_05_ByteAndInteger;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Byte & Integer

        // Byte :
        //      Min Value : 0
        //      MAx Value : 255
        Console.WriteLine("-----> Byte <-----");
        var byteMaxValue = byte.MaxValue;
        var byteMinValue = byte.MinValue;
        Console.WriteLine($"Byte MAX Value is : {byteMaxValue}");
        Console.WriteLine($"Byte MIN Value is : {byteMinValue}");

        // Int :
        //      Min Value : -214748
        //      Max Value :
        Console.WriteLine("-----> Integer <-----");
        var intMaxValue = int.MaxValue;
        var intMinValue = int.MinValue;
        Console.WriteLine($"int MAX Value is : {intMaxValue}");
        Console.WriteLine($"int MIN Value is : {intMinValue}");

        Console.ReadKey();

        #endregion
    }
}