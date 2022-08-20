namespace CS02_04_AssigningValuesToAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // ASSIGNING VALUES TO AN ARRAY | ASSIGNING VALUES TO AN ARRAY
            // We can assign values to individual array elements, by using the index number, like −
            // Dizin öğelerine, dizin numarasını kullanarak aşağıdaki gibi değerler atayabiliriz:
            double[] balance = new double[10];
            balance[0] = 4500.0;
            
            // We can assign values to the array at the time of declaration, as shown −
            // Aşağıda gösterildiği gibi, bildirim sırasında diziye değerler atayabiliriz -
            double[] wage = { 2340.0, 4523.69, 3421.0};
            
            // We can also create and initialize an array, as shown −
            // Ayrıca aşağıda gösterildiği gibi bir dizi oluşturabilir ve başlatabiliriz -
            int [] marks1 = new int[5]  { 99,  98, 92, 97, 95};

            // You may also omit the size of the array, as shown −
            // Aşağıda gösterildiği gibi dizinin boyutunu da atlayabiliriz.
            int [] marks2 = new int[]  { 99,  98, 92, 97, 95};
            
            // You can copy an array variable into another target array variable.
            // In such case, both the target and source point to the same memory location −
            // Bir dizi değişkenini başka bir hedef dizi değişkenine kopyalayabiliriz.
            // Bu durumda, hem hedef hem de kaynak aynı bellek konumuna işaret eder -
            int [] marks3 = new int[]  { 99,  98, 92, 97, 95};
            int[] score = marks3;
            
            // When you create an array, C# compiler implicitly initializes each array element to a default value
            // depending on the array type. For example, for an int array all elements are initialized to 0.
            // Bir dizi oluşturduğumuzda, C# derleyicisi, dizi türüne bağlı olarak her dizi öğesini örtük olarak
            // varsayılan bir değere başlatır. Örneğin, bir int dizisi için tüm öğeler 0 olarak başlatılır.
        }
    }
}