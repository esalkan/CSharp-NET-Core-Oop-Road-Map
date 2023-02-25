namespace CS09_06_SealedKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // We want our derived types not to be derived.
            // Object => BaseType => Staff =>
            //                    => Student => X
            //                    => Instructor => X

            Test test = new Test();
            test.BaseTypeMethod1();

            // Instructor object we don't want to be inherited.

        }
    }
}