namespace CS01_05_ByteAndInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Byte & Integer
            // Byte :
            //      Min Value : 0
            //      MAx Value : 255
            Console.WriteLine("-----> Byte <-----");
            byte byteMaxValue = byte.MaxValue;
            byte byteMinValue = byte.MinValue;
            Console.WriteLine($"Byte MAX Value is : {byteMaxValue}" );
            Console.WriteLine($"Byte MIN Value is : {byteMinValue}");

            // Int :
            //      Min Value : -214748
            //      Max Value :
            Console.WriteLine("-----> Integer <-----");
            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;
            Console.WriteLine($"int MAX Value is : {intMaxValue}");
            Console.WriteLine($"int MIN Value is : {intMinValue}");

            Console.ReadKey();
            #endregion
        }
    }
}

