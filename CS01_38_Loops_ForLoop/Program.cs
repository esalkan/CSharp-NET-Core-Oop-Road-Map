namespace CS01_38_Loops_ForLoop
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

        #region print 5 times Hello
        // print 5 times Hello
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        Console.WriteLine("Hello");
        #endregion

        Console.WriteLine("\n+----------------------------------+\n");

        #region printing 5 times "Hello" with for loop
        // printing 5 times "Hello" with for loop
        for (int i = 1; i < 5; i++) {
            Console.WriteLine(i + "- Hello");
        }
        #endregion
            
        Console.WriteLine("\n+----------------------------------+\n");

        #region Example for loop
        // Example for loop
        for (int i = 0; i <= 10; i++) {
            Console.WriteLine("i = " + i);
        }
        #endregion
            
        Console.WriteLine("\n+----------------------------------+\n");

        #region Example for loop
        // Example for loop
        for (int i = 5; i <= 10; i++) {
            Console.WriteLine("i = " + i);
        }
        #endregion

        Console.WriteLine("\n+----------------------------------+\n");

        #region Example for loop
        // Example for loop
        for (int num = 20; num >= 10; num--) {
            Console.WriteLine("num = " + num);
        }
        #endregion
            
        Console.WriteLine("\n+----------------------------------+\n");

        #region Example for loop
        // Example for loop
        for (int i = 0; i <= 100; i += 10) {
            Console.WriteLine("i = " + i);
        }
        #endregion

        Console.WriteLine("\n+----------------------------------+\n");

        #region Example for loop
        // Example for loop
        for (int i = 50; i >= 0; i -= 5) {
            Console.WriteLine("i = " + i);
        }
        #endregion
            
        Console.WriteLine("\n+----------------------------------+\n");
            
        #region Question | Answer
        // 1-100 arasındaki tüm çift sayıları aynı satırda gösteren bir program yazın
        // Write a program that displays all even numbers between 1-100 in same line
            
        for (int i = 1; i < 100; i++)
        {
            Console.WriteLine($"{i}. Number is : {i}");    
        }
            

        #endregion
            
        Console.WriteLine("\n+----------------------------------+\n");

        #region Question | Answer
        // Write a program that displays all odd numbers between 5-140 in same line
        // 5-140 arasındaki tüm tek sayıları aynı satırda gösteren bir program yazın
        for (int i = 5; i <= 140; i=i+5)
        {
            if (i == 140)
            {
                Console.Write($"{i}");
            }
            else
            {
                Console.Write($"{i}, ");
            }
        }

        #endregion
            
        Console.WriteLine("\n+----------------------------------+\n");

        #region Question | Answer
        // 1 - 100 arasındaki çift sayıları ekran üzerinde yazdıralım.
        // Let's print even numbers from 1 to 100 on the screen.
        for (int i = 1; i <= 100; i++)
        {
            if (i%2 == 0)
            {
                if (i == 100)
                {
                    Console.Write($"{i}");
                }
                else
                {
                    Console.Write($"{i}, ");
                }
            }
        }
        #endregion
            
        Console.WriteLine("\n+----------------------------------+\n");

        #region Question | Answer
        // 1 - 100 arasındaki çift sayıların toplamını ekrana yazdırın.
        // Print the sum of even numbers from 1 to 100.
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine($"Result is {sum}");
        #endregion
            
        Console.WriteLine("\n+----------------------------------+\n");

        #region Question | Answer
        // Kullanıcı klavyeden bir sayı girişi yapacak. Program girilen sayının faktöriyelini hesaplayacak
        // The user will enter a number, Program will calculate factorial of provided number.
        Console.WriteLine("Please enter a number for calculate the factorial.\nFaktöriyel hesaplamak için lütfen bir sayı giriniz.");
        int calculateFactorial = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for (int i = calculateFactorial; i >= 1; i--)
        {
            result *= i;
        }
        Console.WriteLine($"{calculateFactorial}! result is {result}");
        #endregion
            
        Console.WriteLine("\n+----------------------------------+\n");

        #region infinite loop
        /*
        int counter1 = 0;
        for (;;)
        {
            counter1++;
            if (counter1 > 5)
            {
                break;
            }
                
            Console.WriteLine($"Counter is : {counter1} now... I am a infinite loop. But break will stop me in 5");
        }
        */
        #endregion

        #region For Loop Rules
        /* 1-Creating an infinite loop
         * components of the for loop are each optional
         *
         * for( ; ; ) {
         *      Console.WriteLine("Hello");
         * }
         *
         * int iR = 1;
         *
         * for( ;iR<=5;iR++) {
         *      Console.WriteLine(iR);
         * }
         *
         * for (;; iR++) {
         *      Console.WriteLine(iR);
         * }
         *
         * for( ;iR<=5;) {
         *      Console.WriteLine(iR);
         * }
         */
            
        /*
         * 2-Adding Multiple Terms to the for statement
         * int x=0;
         *
         * for(long y=0,z=4 ; x<5 && y<10 ; x++,y++) {
         *      Console.WriteLine(y + " ");
         * }
         *
         * Console.WriteLine(x);
        */
            

        /* 3-Re-declaring a variable in the init block
         * int xR = 0;
         * for(long y=0,x=4; x<5&&y<10; x++,y++) { //does not compile
         *      Console.WriteLine("Hello");
         * }
         *
         * int x = 0;
         * long y = 0;
         *
         * for(y=1,x=4 ; x<5 && y<10 ; x++,y++) {
         *      Console.WriteLine("Hello");
         * }
        */
            
            
        /* 4-Using incompatible data types in the init block the variables in the init block must all be of the same data type
         *
         * for(long y=0, int x=0; x<5 && y<10 ; x++,y++) {
         *      Console.WriteLine("Hello");
         * }
        */
            
        /* 5-Using loop variables outside the loop
         *
         * for(long y=0,x=4; x<5&&y<10; x++,y++) {
         *      Console.WriteLine("Hello");
         * }
         * Console.WriteLine(x); //does not compile
         */


        #endregion
        }
    }
}
