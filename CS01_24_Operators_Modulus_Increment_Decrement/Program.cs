namespace CS01_24_Operators_Modulus_Increment_Decrement;

internal class Program
{
    private static void Main(string[] args)
    {
        // Modulus | Mod Alma
        var s1 = 11;
        var s2 = 2;
        var resultMod = s1 % s2;
        Console.WriteLine("resultMod is : " + resultMod);

        // + --> Unary Plus Operator --> Indicates positive value
        // + --> Unary Plus Operatörü --> Pozitif değeri gösterir
        var i1 = +10;
        var i2 = -100;
        var i3 = -(i1 + i2);

        Console.WriteLine("Sources values : \n" + "int i1 = +10;\n" + "int i2 = -100;\n" + "int i3 = -(i1+i2);\n");

        Console.WriteLine("i1 = " + i1);
        Console.WriteLine("i2 = " + i2);
        Console.WriteLine("i3 = " + i3 + "\n");

        Console.WriteLine("\n+------------------------------o------------------------------+\n");

        // ! --> Logical Complement Operator --> Inverts the value of a boolean
        // ! --> Mantıksal Tamamlayıcı İşleci --> Bir boole değerini tersine çevirir
        var flag = true;
        Console.WriteLine("! --> Logical Complement Operator --> Inverts the value of a boolean");
        Console.WriteLine("boolean flag = true; \nresult is : " + !flag);

        Console.WriteLine("\n+------------------------------o------------------------------+\n");

        // The difference between Pre and Post
        // --> Pre-Increment/Pre-Decrement: When the operator is placed before
        // an operand (++expr, --expr), the variable will be incremented or
        // decremented by 1 in the memory, and the new value is used in the
        // expression in which it appears.

        // Ön ve Son arasındaki fark
        // --> Ön Artırma/Ön Azaltma: Operand bir işlenenin (++expr, --expr) önüne yerleştirildiğinde,
        // değişken bellekte 1 artırılır veya azaltılır ve yeni değer ifadede kullanıldığında görülür...

        // --> Post-Increment/Post-Decrement: When the operator is placed
        // after an operand(expr++,expr--), the old value of the variable
        // will be used in the expression where it appears and then the
        // variable will be incremented or decremented by 1 in the memory.

        // --> Arttırma Sonrası/Azaltma Sonrası: Operatör yerleştirildiğinde
        // bir işlenenden sonra(ifade++,ifade--), değişkenin eski değeri
        // göründüğü ifadede kullanılacak ve ardından
        // değişken bellekte 1 artırılıp azaltılacaktır.

        // ++ --> Increment Operator --> Increments a value by 1
        // -- --> Decrement Operator --> Decrements a value by 1
        int postInc = 10, postDec = 5;
        int preInc = 10, preDec = 5;

        // num1++; // same as num1 = num1 + 1;
        // --num2; // same as num2 = num2 - 1;

        Console.WriteLine("Source variables and values :\n" + "int postInc = 10, postDec = 5;\n"
                                                            + "int preInc = 10, preDec = 5;\n");

        // Post increment
        Console.WriteLine("POST-INCREMENT");
        Console.WriteLine("int postInc = 10;\nPrint it to terminal and incremented in memory result is : " + postInc++);
        Console.WriteLine(
            "After incremented postInc variable value came from memory and result is  : " + postInc + "\n");

        // Post Decrement
        Console.WriteLine("POST-DECREMENT");
        Console.WriteLine("int postDec = 5;\nPrint it to terminal and decrementd in memory result is : " + postDec--);
        Console.WriteLine(
            "After decremented postDec variable value came from memory and result is  : " + postDec + "\n");

        // Pre-increment
        Console.WriteLine("PRE-INCREMENT");
        Console.WriteLine("int preInc = 10;\nFirstly increment it in memory and Print it to terminal result is : "
                          + ++preInc + "\n");

        // Pre-Decrement
        Console.WriteLine("PRE-DECREMENT");
        Console.WriteLine("int pretDec = 5;\nFirstly decrement it in memory and Print it to terminal result is : "
                          + --preDec + "\n");

        Console.WriteLine("\n+------------------------------o------------------------------+\n");

        var i = 11;
        var j = 4;
        var res = i++ + --j;
        Console.WriteLine("Just For Fun Question and it is so nice :\n" + " int i = 11;\n" + " int j = 4;\n"
                          + " int res = i++ + --j;\n");
        Console.WriteLine("res = " + res);
        Console.WriteLine("How it Happen : \n" + "\tres	= 11 + 3\n" + "\ti\t= 11 -> 12\n" + "\tj\t=  4 ->  3\n");
    }
}