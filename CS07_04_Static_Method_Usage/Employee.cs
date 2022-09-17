namespace CS07_04_Static_Method_Usage;

public class Employee
{
    // Fields
    public static string DomainAddress = "codesofmine.com";

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
    
}