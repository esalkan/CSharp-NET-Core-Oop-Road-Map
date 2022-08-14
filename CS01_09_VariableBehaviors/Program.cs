namespace CS01_09_VariableBehaviors;

internal class Program
{
    private static void Main(string[] args)
    {
        var val1 = "User 1";
        var val2 = "User 2";
        val1 = val2;
        val2 = "user 3";
    }
}