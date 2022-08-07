namespace CS01_21_ArithmeticOperators_Substract
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Çıkartma | Substraction (-) Operator
             */

            int num1 = 100;
            int num2 = 50;
            int resultInt = num1 - num2;
            Console.WriteLine("Int substraction result is : " + resultInt);

            byte byt1 = 100;
            byte byt2 = 50;
            var resultByte = byt1 - byt2;
            Console.WriteLine("Byte substraction result is : " + resultByte);
        }
    }
}