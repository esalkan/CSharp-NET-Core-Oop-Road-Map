namespace CS01_32_ControlFlowStatement_IF_ELSEIF_ELSE;

internal class Program
{
    private static void Main(string[] args)
    {
        // IF-ELSE IF-ELSE Statements

        // Program to display days
        // 1-Monday
        // 2-Tuesday
        // 3-Wednesday
        // 4-Thursday
        // 5-Friday
        // 6-Saturday
        // 7-Sunday

        var day = 5;

        if (day == 1)
            Console.WriteLine("Monday");
        else if (day == 2)
            Console.WriteLine("Tuesday");
        else if (day == 3)
            Console.WriteLine("Wednesday");
        else if (day == 4)
            Console.WriteLine("Thursday");
        else if (day == 5)
            Console.WriteLine("Friday");
        else if (day == 6)
            Console.WriteLine("Saturday");
        else if (day == 7)
            Console.WriteLine("Sunday");
        else
            Console.WriteLine("Not a valid day");

        Console.WriteLine("******************************");

        var age = 10;

        if (age < 2 || age > 18)
            Console.WriteLine("ineligible");
        else if (age == 2)
            Console.WriteLine("toddler");
        else if (age >= 3 && age <= 5)
            Console.WriteLine("early childhood");
        else if (age == 6 || age == 7)
            Console.WriteLine("young reader");
        else if (age >= 8 && age <= 10)
            Console.WriteLine("elementary");
        else if (age == 11 || age == 12)
            Console.WriteLine("middle");
        else if (age == 13)
            Console.WriteLine("imposible");
        else if (age >= 14 && age <= 16)
            Console.WriteLine("high school");
        else if (age == 17 || age == 18) Console.WriteLine("scholar");
    }
}