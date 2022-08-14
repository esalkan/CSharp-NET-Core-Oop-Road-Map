namespace CS01_30_Exercise_06;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Kullanıcıdan gelen 3 farklı sınav notunun ortalaması 45 değerine eşit veya büyük mü kontrolünü sağlayın.
         * Check if the average of 3 different exam grades from the user is equal to or greater than 45.
         */

        string exam1, exam2, exam3;

        Console.WriteLine("Exam 1 result : ");
        exam1 = Console.ReadLine();

        Console.WriteLine("Exam 2 result : ");
        exam2 = Console.ReadLine();

        Console.WriteLine("Exam 3 result : ");
        exam3 = Console.ReadLine();

        var examD1 = Convert.ToDecimal(exam1);
        var examD2 = Convert.ToDecimal(exam2);
        var examD3 = Convert.ToDecimal(exam3);

        var avg = (examD1 + examD2 + examD3) / 3;
        var result = avg >= 45;
        Console.WriteLine($"Average Value is : {result}");

        Console.WriteLine("--------------- o ---------------");

        /*
         * UserName : admin
         * Password : 123
         */

        string userName, password;

        Console.WriteLine("User Name : ");
        userName = Console.ReadLine();

        Console.WriteLine("Password : ");
        password = Console.ReadLine();

        var userNameControl = userName is "admin";
        var passwordControl = password is "123";

        Console.WriteLine($"Given UserName is {userNameControl}\nGiven Password is {true}");
    }
}