namespace CS01_12_ConsiciousTypeCasting;

internal class Program
{
    private static void Main(string[] args)
    {
        // NOTE : Run the project in DEBUG mode from line 14. Go step-by-step, see the process and errors.
        // NOT  : Projeyi 14. satırdan DEBUG modunda çalıştırın. Adım adım gidin, süreci ve hataları görün.

        // Bilinçli Tür Dönüşümü
        // Consicious Type Casting

        byte num1 = 100; // True
        var byteMin = byte.MinValue; // 0
        var byteMax = byte.MaxValue; // 255
        // num1 = 256; compile time error occurs

        var num2 = 256;
        var intMin = int.MinValue;
        var intMax = int.MaxValue;
        Console.WriteLine(intMin);
        Console.WriteLine(intMax);

        int num3 = num1; // Consicious Type Casting
        /*
         * num1 data type is "byte" and it value range between 0 - 255
         * num3 data type is "int" and it value range between  -2147483648 - 2147483647
         * int data type can keep in it more bigger values than byte and we know that.
         * and we assign num1 value to num3 and it data type become int. This is Consicious type Casting.
         *
         * num1 veri türü "byte" ve 0 - 255 arasında değer aralığını tutabilir.
         * num3 veri türü "int" ve -2147483648 - 2147483647 arasında değer aralığı tutabilir.
         * int veri türü, içinde bayttan daha büyük değerler tutabilir ve bunu biliyoruz.
         * Ve num1 değerini num3'e atarız ve veri türü "int" olur. Bu Bilinçli bir tür dönüşümüdür.
         */
    }
}