namespace CS04_10_Local_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalFunctionUsage(2,2);
        }

        static void LocalFunctionUsage(int num1, int num2)
        {
            // Local Functions usage came with .NET 7
            int sum(int incomingNum1, int incomingNum2)
            {
                return incomingNum1 + incomingNum2;
            }

            int totalValue = sum(num1, num2);

            Console.WriteLine($"Total Value is : {totalValue}");
        }
    }
}