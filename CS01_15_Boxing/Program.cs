namespace CS01_15_Boxing;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * OBJECT tüm tipleri kapsayan bir tiptir. Bütün tipleri kendi içerisinde muhafaza edebilir.
         * OBJECT is a type that covers all types. It can keep all types within itself.
         * object{
         *      Integer,
         *      Decimal,
         *      String,
         *      Bool,
         *      Float,
         *      Double,
         *      Class,
         *      Custom Class
         *  }
         */

        // Kutulama
        // Boxing
        object o1 = 100;
        object o2 = 10.90;
        object o3 = "C# Road Map";

        var i = 123;

        // Boxing copies the value of i into object o.
        object o = i;

        // Change the value of i.
        i = 456;

        // The change in i doesn't affect the value stored in o.
        Console.WriteLine("The value-type value = {0}", i);
        Console.WriteLine("The object-type value = {0}", o);

        // String.Concat example.
        // String.Concat has many versions. Rest the mouse pointer on
        // Concat in the following statement to verify that the version
        // that is used here takes three object arguments. Both 42 and
        // true must be boxed.
        Console.WriteLine(string.Concat("Answer", 42, true));

        // List example.
        // Create a list of objects to hold a heterogeneous collection
        // of elements.
        var mixedList = new List<object>();

        // Add a string element to the list.
        mixedList.Add("First Group:");

        // Add some integers to the list.
        for (var j = 1; j < 5; j++)
            // Rest the mouse pointer over j to verify that you are adding
            // an int to a list of objects. Each element j is boxed when
            // you add j to mixedList.
            mixedList.Add(j);

        // Add another string and more integers.
        mixedList.Add("Second Group:");
        for (var j = 5; j < 10; j++) mixedList.Add(j);

        // Display the elements in the list. Declare the loop variable by
        // using var, so that the compiler assigns its type.
        foreach (var item in mixedList)
            // Rest the mouse pointer over item to verify that the elements
            // of mixedList are objects.
            Console.WriteLine(item);

        // The following loop sums the squares of the first group of boxed
        // integers in mixedList. The list elements are objects, and cannot
        // be multiplied or added to the sum until they are unboxed. The
        // unboxing must be done explicitly.
        var sum = 0;
        for (var j = 1; j < 5; j++)
            // The following statement causes a compiler error: Operator
            // '*' cannot be applied to operands of type 'object' and
            // 'object'.
            //sum += mixedList[j] * mixedList[j]);

            // After the list elements are unboxed, the computation does
            // not cause a compiler error.
            sum += (int)mixedList[j] * (int)mixedList[j];

        // The sum displayed is 30, the sum of 1 + 4 + 9 + 16.
        Console.WriteLine("Sum: " + sum);
    }
}