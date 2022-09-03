namespace CS04_03_Defining_Method;

public class Student
{
    /*
     * Defining Methods in C#
     * When we define a method, we basically declare the elements of its structure. The syntax for defining
     * a method in C# is as follows;
     *      <Access Specifier> <Return Type> <Method Name> (Parameter List){
     *              Method Body
     *      }
     *
     * Access Modifiers
     *  - Public
     *  - Private
     *  - Protected
     *  - Internal
     *  - Internal Protected
     *
     * C# ile Metot Tanımlama
     *      Bir metot tanımladığımızda, temelde onun yapısının elemanlarını beyan etmiş olursunuz.
     *      C#'ta bir yöntem(metot) tanımlamanın sözdizimi aşağıdaki gibidir -
     *
     *          <Erişim Tanımlayıcı> <Dönüş Tipi> <Metot Adı>(Parametre Listesi) {
     *              Metot Gövdesi
     *          }
     * 
     * Erişim Belirleyiciler
     *  - Public    (Umumi)
     *  - Private   (Gizli) 
     *  - Protected (Korumalı)
     *  - Internal  (Dahili)
     *  - Internal Protected (Dahili Korumalı)
     */

    public void SM_Greeting()
    {
        Console.WriteLine("Hello Student! | Merhaba Öğrenci!");
    }

    public void SM_Name_Surname(string studentName, string studentSurname)
    {
        Console.WriteLine($"Student Informations : {studentName} {studentSurname}");
        Console.WriteLine($"Öğrenci Bilgileri : {studentName} {studentSurname}");
    }
    
    private void SM_Private_Name_Surname(string studentName, string studentSurname)
    {
        Console.WriteLine($"Student Informations : {studentName} {studentSurname}");
        Console.WriteLine($"Öğrenci Bilgileri : {studentName} {studentSurname}");
    }

    public void SM_Call_Private_Name_Surname_Method()
    {
        SM_Private_Name_Surname("Güdük", "Necmi");
    }
    
    
}