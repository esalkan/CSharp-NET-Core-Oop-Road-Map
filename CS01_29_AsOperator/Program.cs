namespace CS01_29_AsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * As Operator
             * Elimizdeki herhangi bir nesneyi T tipine çevirebiliyorsa, çeviren, yok eğer çeviremiyorsa null dönen bir operatördür.
             * If it can convert any object we have to the type T, it is an operator that converts, or if it cannot, it returns null.
             */
            object language = "C# Java Python";
            object objectString = language;
            string resultStr = objectString as string;
            
        }
    }
}