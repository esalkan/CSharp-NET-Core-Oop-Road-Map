namespace CS01_38_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loops check a condition. If it returns true, a code block will run. Then the
            // condition will
            // be checked again and if it is still returns true, the code block will run
            // again. It repeats
            // until the condition return false
            //
            // There is 3 Loops
            // 1- For Loop
            // 2- While Loop
            // 3- Do While Loop
            
            // If you need to run code a specific number of times, use a for loop. In a for
            // loop, the
            // condition is usually a counter which is used to tell how many times the loop
            // should run.
            // init = initialization

            // print 5 times Hello
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");

            Console.WriteLine("\n+----------------------------------+\n");

            // printing 5 times "Hello" with for loop
            for (int i = 1; i < 5; i++) {
                Console.WriteLine(i + "- Hello");
            }

            Console.WriteLine("\n+----------------------------------+\n");

            // Example for loop
            for (int i = 0; i <= 10; i++) {
                Console.WriteLine("i = " + i);
            }

            Console.WriteLine("\n+----------------------------------+\n");

            // Example for loop
            for (int i = 5; i <= 10; i++) {
                Console.WriteLine("i = " + i);
            }

            Console.WriteLine("\n+----------------------------------+\n");

            // Example for loop
            for (int num = 20; num >= 10; num--) {
                Console.WriteLine("num = " + num);
            }

            Console.WriteLine("\n+----------------------------------+\n");

            // Example for loop
            for (int i = 0; i <= 100; i += 10) {
                Console.WriteLine("i = " + i);
            }

            Console.WriteLine("\n+----------------------------------+\n");

            // Example for loop
            for (int i = 50; i >= 0; i -= 5) {
                Console.WriteLine("i = " + i);
            }
        }
    }
}