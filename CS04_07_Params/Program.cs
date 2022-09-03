using System.Diagnostics.CodeAnalysis;

namespace CS04_07_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Params
             *
             * By using the params keyword, we can specify a method parameter that takes a variable number of arguments.
             * The parameter type must be a single-dimensional array.
             *
             * No additional parameters are permitted after the params keyword in a method declaration,
             * and only one params keyword is permitted in a method declaration.
             *
             * If the declared type of the params parameter is not a single-dimensional array, compiler error CS0225 occurs.
             *
             * When we call a method with a params parameter, we can pass in:
             *      - A comma-separated list of arguments of the type of the array elements.
             *      - An array of arguments of the specified type.
             *      - No arguments. If we send no arguments, the length of the params list is zero.
             *
             * ---------------------------------------------------------------------------------------------------------
             * 
             * "params" anahtar sözcüğünü kullanarak, değişken sayıda bağımsız değişken alan bir yöntem parametresi belirtebiliriz.
             * Parametre türü tek boyutlu bir dizi olmalıdır.
             *
             * Bir yöntem bildiriminde params anahtar sözcüğünden sonra hiçbir ek parametreye izin verilmez
             * ve bir yöntem bildiriminde yalnızca bir params anahtar sözcüğüne izin verilir.
             *
             * Params parametresinin bildirilen türü tek boyutlu bir dizi değilse, CS0225 derleyici hatası oluşur.
             *
             * Params parametreli bir yöntemi çağırdığımızda, şunları iletebiliriz:
             *      - Dizi öğelerinin türünün virgülle ayrılmış bağımsız değişken listesi.
             *      - Belirtilen türde bir argüman dizisi.
             *      - Argüman yoksa. Argüman gönderemeyiz, params listesinin uzunluğu sıfırdır.
             * 
             */
            
            // We can send a comma-separated list of arguments of the specified type.
            // Belirtilen tipte virgülle ayrılmış bir argüman listesi gönderebiliriz.
            UseParams(1, 2, 3, 4);
            UseParams2(1, 'a', "test");

            // A params parameter accepts zero or more arguments.
            // The following calling statement displays only a blank line.
            UseParams2();

            // An array argument can be passed, as long as the array
            // type matches the parameter type of the method being called.
            // Params parametresi sıfır veya daha fazla argüman kabul eder.
            // Aşağıdaki çağrı ifadesi yalnızca boş bir satır görüntüler.
            int[] myIntArray = { 5, 6, 7, 8, 9 };
            UseParams(myIntArray);

            object[] myObjArray = { 2, 'b', "test", "again" };
            UseParams2(myObjArray);

            // The following call causes a compiler error because the object
            // array cannot be converted into an integer array.
            // Aşağıdaki çağrı, nesne nedeniyle bir derleyici hatasına neden olur
            // dizi bir tamsayı dizisine dönüştürülemez.
            //UseParams(myObjArray);

            // The following call does not cause an error, but the entire
            // integer array becomes the first element of the params array.
            // Aşağıdaki çağrı bir hataya neden olmaz, ancak tüm
            // tamsayı dizisi, params dizisinin ilk öğesi olur.
            UseParams2(myIntArray);
            
            
            Addition(1,2,3,4,5,6,7,8,9,10);
            
        }
        
        public static void UseParams(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        public static void UseParams2(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Addition(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Sum is : {sum}");
        }
    }
}