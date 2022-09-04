namespace CS05_04_Using_Of_Methods_In_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new Customer
            Customer c1 = new Customer("01234567890", "Customer 4", "C4Surname", 717770001);
            
            bool c1Control = c1.CustomerControl(); // We are not sending any id because it will take the id in memory.
            
            Console.WriteLine($"Customer Control is return : {c1Control}");
        }
    }
}