namespace CS05_03_Constructor_Method;

public class Customer
{
    public string Id;
    public string name;
    public string surname;
    public int gender;
    
    // Constructor Method (ctor)
    // Default constructor - Non parameterized
    public Customer()
    {
        
    }
    
    // Constructor - Parameterized
    public Customer(string _Id)
    {
        Id = _Id;
    }
    
    public Customer(string _Id, string _name)
    {
        Id = _Id;
        name = _name;
    }
    
    public Customer(string _Id, string _name, string _surname)
    {
        Id = _Id;
        name = _name;
        surname = _surname;
    }
    public Customer(string _Id, string _name, string _surname, int _gender)
    {
        Id = _Id;
        name = _name;
        surname = _surname;
        gender = _gender;
    }
}