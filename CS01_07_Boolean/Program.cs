namespace CS01_07_Boolean;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Boolean

        /*
         * Değerleri kullanıcıdan al        / Get values from user
         * Değerleri değişkenlere kayıt et  / Save values to variables
         * Değerleri kontrol et             / Check values
         * Değerleri veritabanından doğrula / Validate values from database
         * Evet/Yes  => True
         * Hayır/No  => False
         */

        var userLogInResult = true;
        Console.WriteLine($"User Login Result is : {userLogInResult}");

        userLogInResult = false;
        Console.WriteLine($"User Login Result is : {userLogInResult}");

        // Default value is false
        // Varsayılan değer FALSE
        bool userValue;
        // If run the project in debug mode you can see the default value is false
        // Projeyi hata ayıklama modunda çalıştırırsanız, varsayılan değerin false olduğunu görebilirsiniz.

        // Assign a value to the variable
        // Değişkene değer atama
        userValue = true;

        #endregion
    }
}