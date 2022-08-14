namespace CS01_17_VarKeyword;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Metod kapsamında bildirilen değişkenler örtük bir "türe" varsahip olabilir.
         * Örtük olarak yazılan bir yerel değişken, türü kendiniz bildirmişsiniz gibi kesin olarak yazılmıştır,
         * ancak türü derleyici belirler. Aşağıdaki iki bildirimi i işlevsel olarak eşdeğerdir:
         *
         * Variables that are declared at method scope can have an implicit "type" var.
         * An implicitly typed local variable is strongly typed just as if you had declared the type yourself,
         * but the compiler determines the type. The following two declarations of i are functionally equivalent:
         */
        var n1 = 10; // Implicitly typed.
        var n2 = 10; // Explicitly typed.
        var n3 = "This is String"; // Implicitly typed.
    }
}