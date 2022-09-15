namespace CS07_02_Static;

public class WhatIsStatic
{
    public string Name { get; set; }        // This is a property and field
    public string LastName { get; set; }
    public string EmailAddress { get; set; }

    public void Test1()
    {
        Console.WriteLine("This is the method that runs after the object instance is created.");
        Console.WriteLine("Bu, nesne örneği oluşturulduktan sonra çalışan yöntemdir.");
    }

    public static void Test2()
    {
        Console.WriteLine("This is the method that runs without instantiating the object.");
        Console.WriteLine("Bu, nesne örneği oluşturulmadan çalışan yöntemdir.");
    }

    public static void Test3()
    {
        Console.WriteLine("Static olan metot static olmayan metot tarafından çağırılabilir.");
        Console.WriteLine("A static method can be called by a non-static method.");
        Console.WriteLine();
        Console.WriteLine("Static olmayan metot static olmayan metot tarafından çağırılamaz");
        Console.WriteLine("A non-static method cannot be called by a non-static method.");
    }
}