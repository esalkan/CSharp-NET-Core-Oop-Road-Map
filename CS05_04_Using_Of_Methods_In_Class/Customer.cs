namespace CS05_04_Using_Of_Methods_In_Class;


public class Customer
{
    public string Id;
    public string name;
    public string surname;
    public int gender;

    #region Constructors
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

    #endregion

    #region Methods

    public bool CustomerControl()
    {
        bool customerControl = CustomerDBControl(Id);
        return customerControl;
    }

    private bool CustomerDBControl(string _Id)
    {
        // Assume that,
        // This code block will connect to the database
        // and query whether the customer is registered or not and return true or false to us.
        return true;
    } 

    #endregion
}