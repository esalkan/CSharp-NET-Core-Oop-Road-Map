namespace CS01_03_StringVariableTypeAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Variable Type & String Methods
            string nameSurname = "Eyüp Sabri ALKAN";
            Console.WriteLine("-----> String Variable Type <-----");
            // String Type
            nameSurname = "Ayşe ALKAN"; // Change the nameSurname Value

            Console.WriteLine("-----> String Methods <-----");
            string toUpper = nameSurname.ToUpper();
            string toLower = nameSurname.ToLower();
            string subString = nameSurname.Substring(2, 5);
            Console.WriteLine(nameSurname.GetType());

            Console.WriteLine(toUpper);
            Console.WriteLine(toLower);
            Console.WriteLine(subString);
            #endregion
        }
    }
}