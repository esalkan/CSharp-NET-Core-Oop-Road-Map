namespace CS04_09_Method_Use_In_Method_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowOnTerminal(Sum(1, 2, 3));
        }

        public static void ShowOnTerminal(object o)
        {
            Console.WriteLine($"Result is : {o}");
        }

        public static int Sum(int num1, int num2, int num3 = 0)
        {
            int result = num1 + num2 + num3;
            return result;
        }
        
        public static decimal Sum(decimal num1, decimal num2, decimal num3 = 0)
        {
            decimal result = num1 + num2 + num3;
            return result;
        }
        
        
    }
}