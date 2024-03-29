﻿namespace CS01_34_ControlFlowStatement_SwitchCase;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Data types supported by switch statements:
         * Switch deyimleri tarafından desteklenen veri türleri:
         *	- int
         *	- byte
         *	- short
         *	- char
         *	- String
         *
         * Data types NOT supported by switch statements:
         * Switch ifadeleri tarafından DESTEKLENMEYEN veri türleri:
         *  - boolean
         *  - long
         *  - double
         *  - float
         *
         * Switch statements data type for case statements must all match the data type of the switch variable
         * Case deyimleri için switch deyimleri veri türünün tümü, switch değişkeninin veri türüyle eşleşmelidir
         *
         * Case statement value must be final constant variable // Case deyimi değeri nihai sabit değişken olmalıdır
         * "" is using for string values
         * '' is using just for char values
         */

        const string lastName = "Smith";
        var firstName = "Mike";
        var id = 0;

        switch (firstName)
        {
            case "Mike":
                Console.WriteLine("Test");
                break;
            case lastName: // if this case statement value is came from
                // it is must be cover with final as shown above
                id = 5;
                break;
            // case 5:
            // break
        }

        Console.WriteLine("----------> o <----------");
        Console.WriteLine("Make a selection within the first 3 months\nİlk 3 ay içerisinden bir seçim yapın : ");
        var userInput = Console.ReadLine();

        switch (userInput)
        {
            case "January":
                Console.WriteLine("01");
                break;
            case "Ocak":
                Console.WriteLine("01");
                break;
            case "February":
                Console.WriteLine("02");
                break;
            case "Şubat":
                Console.WriteLine("02");
                break;
            case "March":
                Console.WriteLine("03");
                break;
            case "Mart":
                Console.WriteLine("03");
                break;
            default:
                Console.WriteLine("You entered a value other than the specified value.");
                Console.WriteLine("Belirtilen değerlerin dışında bir değer girişi yaptınız.");
                break;
        }

        Console.WriteLine("----------> o <----------");
        Console.WriteLine("Make a selection within the first 3 months\nİlk 3 ay içerisinden bir seçim yapın : ");
        var userInputOrLogic = Console.ReadLine();

        switch (userInputOrLogic)
        {
            case "January":
            case "Ocak":
                Console.WriteLine("01");
                break;
            case "February":
            case "Şubat":
                Console.WriteLine("02");
                break;
            case "March":
            case "Mart":
                Console.WriteLine("03");
                break;
            default:
                Console.WriteLine("You entered a value other than the specified value.");
                Console.WriteLine("Belirtilen değerlerin dışında bir değer girişi yaptınız.");
                break;
        }
    }
}