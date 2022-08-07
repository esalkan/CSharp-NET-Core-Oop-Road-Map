namespace CS01_20_ArithmeticOperators_Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Addition Operator
             * Toplama Operatörü
             * "+"
             * int + int 
             */

            int num1 = 10;
            int num2 = 15;
            int resultSum = num1 + num2;
            Console.WriteLine("resultSum" + resultSum);

            byte num3 = 10;
            byte num4 = 10;
            var resultByte = num3 + num4;
            Console.WriteLine("resultByte is : " + resultByte);
            
            // string   +   int     (string)
            // int      +   string  (string)
            // string   +   string  (string)s
            string str1 = "Hello";
            string resultStr = str1 + num1;
            Console.WriteLine("str1 + num1 : " + str1 + num1);

            
        }
    }
}