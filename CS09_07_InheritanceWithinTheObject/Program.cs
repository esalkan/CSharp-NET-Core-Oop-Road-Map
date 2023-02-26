namespace CS09_07_InheritanceWithinTheObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor I1 = new Instructor();

            // When we inherit objects, their behavior is like below example. (Please check related classes)

            // First Run:   Step by step
            //              Instructor => Staff => BaseType => Object
            //
            // Returning Back:  Step by step
            //                  Object => BaseType => Staff => Instructor
        }
    }
}