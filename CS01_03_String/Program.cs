namespace CS01_03_String;

internal class Program
{
    private static void Main(string[] args)
    {
        #region String Variable Type & String Methods

        var nameSurname = "Eyüp Sabri ALKAN";
        Console.WriteLine("-----> String Variable Type <-----");
        // String Type
        nameSurname = "Ayşe ALKAN"; // Change the nameSurname Value

        Console.WriteLine("-----> String Methods <-----");
        var toUpper = nameSurname.ToUpper();
        var toLower = nameSurname.ToLower();
        var subString = nameSurname.Substring(2, 5);
        Console.WriteLine(nameSurname.GetType());

        Console.WriteLine(toUpper);
        Console.WriteLine(toLower);
        Console.WriteLine(subString);

        #endregion
    }
}