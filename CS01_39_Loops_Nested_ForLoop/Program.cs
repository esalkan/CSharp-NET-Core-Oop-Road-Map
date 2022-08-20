namespace CS01_39_Loops_Nested_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Nested For Loop

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            #endregion
            
            Console.WriteLine("\n+----------------------------------+\n");
            
            #region Nested Loop
            for (int i = 1; i <= 5; i++) { 
                Console.WriteLine("Outer Loop Iteration : " + i); 
                for (int j = 1; j <= 3; j++) { 
                    Console.WriteLine("i = " + i + "; j = " + j); 
                    for (int j2 = 0; j2 < 2; j2++) {
                        
                    }
                }
            }
            #endregion

            Console.WriteLine("\n+----------------------------------+\n");
            
            #region Nested Loop 1
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Outter Loop at state : " + i);
                for (int p = 0; p <= 3; p++) {
                    Console.WriteLine("Inner loop at state : " + p);
                    if (p == 3) {
                        Console.WriteLine();
                    }
                }
            }
            #endregion
            
            Console.WriteLine("\n+----------------------------------+\n");

            #region Nested Loop 2

            for (int i = 0; i <= 6; i++) {

                for (int j = 0; j <= 6; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
            
            Console.WriteLine("\n+----------------------------------+\n");

            #region Nested Loop 3
            for (int i = 1; i <= 7; i++) {

                for (int j = 1; j <= i; j++) {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            #endregion

            Console.WriteLine("\n+----------------------------------+\n");
            
            #region Exercise
            int rows7 = 7;

            for (int i = 1; i <= rows7; i++) {

                for (int j = 1; j <= i; j++) {
                    Console.Write(" ");
                }
                Console.WriteLine("#");
            }
            

            #endregion

            Console.WriteLine("\n+----------------------------------+\n");
            
            #region Exercise

            int rows5 = 5;

            for (int i = 1; i <= rows5; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}