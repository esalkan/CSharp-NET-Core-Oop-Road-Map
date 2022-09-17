namespace CS07_06_Static_NonStatic_Constructors;

public class Employee
{
    // Fields
    public static string DomainAddress;

    private string emailAddress;
    // Properties
    public string Name { get; set; }
    public string LastName { get; set; }

    public string EmailAddress
    {
        get
        {
            return this.emailAddress;
        }
        set
        {
            this.emailAddress = value.ToLower() + "@" + Employee.DomainAddress;
        }
    }

    public int Gender { get; set; }
    
    // Non-Static Constructor
    public Employee()
    {
        Console.WriteLine("Non-Static Constructor method which is running in each instantiating.");
        Console.WriteLine("Her örneklemede çalışan Statik Olmayan Oluşturucu yöntemi.");
        Console.WriteLine();
    }

    static Employee()
    {
        DomainAddress = "codesofmine.com";
        Console.WriteLine("Static Constructor Method Run.");
        Console.WriteLine("Static Yapıcı Method Çalıştı.");
        Console.WriteLine();
    }
}