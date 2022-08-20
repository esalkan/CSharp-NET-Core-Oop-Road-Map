namespace CS01_09_VariableBehaviors
{
    class Program
    {
        static void Main(string[] args)
        {
            var val1 = "User 1";
            Console.WriteLine(val1);
            var val2 = "User 2";
            Console.WriteLine(val2);
            val1 = val2;
            val2 = "user 3";
            
            
            Console.WriteLine(val1);
            Console.WriteLine(val2);
        }
    }
}