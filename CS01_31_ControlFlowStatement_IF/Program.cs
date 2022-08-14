namespace CS01_31_ControlFlowStatement_IF;

internal class Program
{
    private static void Main(string[] args)
    {
        // IF Statement
        // IF Ifadesi

        var score = 80;

        if (score != 70)
        {
            Console.WriteLine("Excellent!");
            Console.WriteLine("You passed with grade : A");
        }

        Console.WriteLine("---------- o ----------");

        int sales, bonus;
        decimal commisionRate, salary;

        sales = 6000;
        salary = 5;

        if (true)
        {
            bonus = 500;
            commisionRate = 1.12m;

            salary = salary * commisionRate * bonus;
        }

        Console.WriteLine("Salary : " + salary);

        Console.WriteLine("---------- o ----------");

        Console.WriteLine("Enter first number : ");
        var sStr1 = Console.ReadLine();

        Console.WriteLine("Enter second number : ");
        var sStr2 = Console.ReadLine();

        var num1 = Convert.ToDecimal(sStr1);
        var num2 = Convert.ToDecimal(sStr2);
        var sum = num1 + num2;

        var control = sum > 50;

        //if (control)
        //{
        //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyük....");
        //    Console.WriteLine("The sum of the values you entered is greater than 50.");
        //}

        if (sum > 50)
        {
            Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyük....");
            Console.WriteLine("The sum of the values you entered is greater than 50.");
        }
    }
}