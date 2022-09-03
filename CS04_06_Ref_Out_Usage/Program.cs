namespace CS04_06_Ref_Out_Usage
{
    class Program
    {
        /*
         * ref and out keywords
         * 
         * Aslında değer tipli davranışa sahip olan değişkenlerin referans tipli davranışa sahip olmasına olanak tanır.
         *
         *  Ref ve Out aslında benzer amaç için kullanılır.Temel farkları ise;
         *      - Ref kullanırken varsayılan değer ataması zorunludur, Out için bu zorunluluk yoktur.
         *      - Metot’a out anahtar sözcüğü ile geçilen değişkenin aynı metot içinde değer ataması yapılması zorunlu iken,
         *        Ref için böyle bir zorunluluk yoktur.
         *
         * 
         * It allows variables that actually have value-type behavior to have reference-type behavior.
         *
         *  Ref and Out are actually used for similar purposes. The main differences are;
         *      - Default value assignment is required when using Ref, Out does not.
         *      - While the variable passed to the method with the out keyword must be assigned a value within the same method,
         *        there is no such requirement for Ref.
         *
         *
         * https://docs.microsoft.com/tr-tr/dotnet/csharp/language-reference/keywords/ref
         * https://docs.microsoft.com/tr-tr/dotnet/csharp/language-reference/keywords/out-parameter-modifier
         * 
         */
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2;
            AddValue(ref num1);
            AddValue1(out num2);
        }

        static void AddValue(ref int arrivedValue)
        {
            arrivedValue = 10;
        }

        static void AddValue1(out int arrivedValue)
        {
            arrivedValue = 20;
        }
    }
}