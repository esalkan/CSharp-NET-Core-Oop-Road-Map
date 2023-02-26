namespace CS09_08_ProtectedKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Access Modifiers
             * 
             *  public      : It means that it can be accessed inside or outside the application.
             *  private     : It means that it can be accessed within the class it is defined in.
             *  protected   : It behaves as private in normal usage. It means that it is used as public in another class by inheritance.
             *  
             */

            BaseType baseType = new BaseType();
            // Let's try to access BaseTypeMethod2();
            // baseType.    
            // We can not see the BaseTypeMethod2() it is in BaseType class behaves as private. Which class is having inheritance
            // On it we can access to the protected properties/methods etc...

            Student student = new Student();
            // Let's try to access BaseTypeMethod2();
            // student.
            // We can not see the BaseTypeMethod2() it is in BaseType class behaves as private. Which class is having inheritance
            // On it we can access to the protected properties/methods etc...
        }
    }
}