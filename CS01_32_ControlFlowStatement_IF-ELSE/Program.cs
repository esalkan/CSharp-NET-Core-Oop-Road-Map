namespace CS01_32_ControlFlowStatement_IF_ELSE;

internal class Program
{
    private static void Main(string[] args)
    {
        // IF-ELSE Statements

        var score = 60;

        if (score >= 70)
        {
            Console.WriteLine("Excelent");
            Console.WriteLine("You Passed With Grade A");
        }
        else
        {
            Console.WriteLine("Your Score is  : " + score);
            Console.WriteLine("You fail");
        }
    }
}