namespace CS01_13_UnconsciousTypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE : Run the project in DEBUG mode from line 14. Go step-by-step, see the process and errors.
            // NOT  : Projeyi 14. satırdan DEBUG modunda çalıştırın. Adım adım gidin, süreci ve hataları görün.
            /*
             * Bilinçsiz Tür Dönüşümü
             * Unconscious Type Casting
             */

            int num1 = 100;
            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            /*
             * Aşağıda byte veri tipinde bir değişkene "int" tipinde veri tutan bir değişkenin değerini atamaya çalışıyoruz.
             * Bu bize compileTime error döndürmektedir. Büyük veri tipi tutan bir değişkeni kendinden daha düşük veri tipi
             * tutan bir değişkene dönüştüremiyoruz.
             * 
             * Below we are trying to assign the value of a variable holding data of type "int" to a variable of data type byte.
             * This returns us a compileTime error.
             * We cannot convert a variable holding a large data type to a variable holding a lower data type.
             */
            // byte num2 = num1; 
            
            /*
             * bu işlemi yapabilmek için aşağıdaki yöntemi kullanabiliriz. Bu işlem düzgün yapılmazsa değer ataması
             * yapılamamış olur ve bu büyük hatalara neden olur.
             *
             * We can use the following method to do this. If this process is not done properly,
             * the value assignment will not be possible and this will cause big errors.
             */
            byte num2 = (byte)num1;
            
        }
    }
}

