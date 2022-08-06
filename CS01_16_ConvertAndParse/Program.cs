namespace CS01_16_ConvertAndParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "100";
            string str2 = "True";
                
            Console.WriteLine(str1.GetType());  // System.String
            Console.WriteLine(str2.GetType());  // System.String
            
            // Parse
            Console.WriteLine("-----> Parse <-----");
            int s1 = int.Parse(str1);           // Parse "string" to "int"
            Console.WriteLine(s1.GetType());    // System.Int32
            Console.WriteLine(s1);

            Console.WriteLine();
            
            bool s2 = bool.Parse(str2);         // Parse "string" to "bool"
            Console.WriteLine(s2.GetType());    // System.Boolean
            Console.WriteLine(s2);
            
            // Convert
            Console.WriteLine("-----> Convert <-----");
            int s3 = Convert.ToInt32(str1);     // Convert "string" to "int"
            Console.WriteLine(s3.GetType());    // System.Int32
            Console.WriteLine(s3);
            
            // Difference Between Parse And Convert
            // Parse ve Convert Arasındaki fark
            // Aradaki farkı görmek için satır 36'i debug modda çalıştırın.
            // Run line 36 in debug mode to see the difference.
            
            string str3 = null;
            decimal d2 = Convert.ToInt32(str3);   // null values automatically convert to data type. That will convert "null" to "0" based on data type.
            // decimal d1 = decimal.Parse(str3);    // null values not acceptable for PARSE (Will return exception)

        }
    }
}