namespace CS01_29_AsOperator;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * As Operator
         * Elimizdeki herhangi bir nesneyi T tipine çevirebiliyorsa, çeviren, yok eğer çeviremiyorsa null dönen bir operatördür.
         * If it can convert any object we have to the type T, it is an operator that converts, or if it cannot, it returns null.
         */
        object language = "C# Java Python";
        var objectString = language;
        var resultStr = objectString as string;
    }
}