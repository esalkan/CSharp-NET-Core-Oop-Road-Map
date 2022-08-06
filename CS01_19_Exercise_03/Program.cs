namespace CS01_19_Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
        // Soru 1 : String olarak verilen değeri bool tipine dönüştürün
        // Question 1: Convert String value to bool type
        string str1 = "True";
        
        // Answer | Cevap
        Console.WriteLine($"string str1 = \"True\";\nstr1 type is : {str1.GetType()}");
        Console.WriteLine(str1);

        Console.WriteLine();
        
        bool bVar = Convert.ToBoolean(str1);
        Console.WriteLine($"bool bVar = Convert.ToBoolean(str1);\nbVar type is : {bVar.GetType()}");
        Console.WriteLine(bVar);

        Console.WriteLine();
        
        // Soru 2 : int içerisinde olan 100 değerini byte ve float değişken tiplerine dönüştürün.
        // Question 2: Convert the value of 100 in int to byte and float variable types.
        int num1 = 100;
        
        // Answer | Cevap
        byte byteVal = (byte)num1;
        float floatVal = num1;
        
        Console.WriteLine(byteVal);
        Console.WriteLine(floatVal);
        
        // Soru 3 : Byte değişken içerisinde olan tipi Decimal değişken tipine dönüştürün.
        // Question 3: Convert the type in byte variable to Decimal variable type.
        byte b1 = 10;
        decimal dVal = b1;

        }
    }
}