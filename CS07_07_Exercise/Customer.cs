using System.Collections;

namespace CS07_07_Exercise;

public class Customer
{
    #region Virtual Database
    private static ArrayList _customerDatabase;
    #endregion

    #region Static Constructor Metod
    static Customer()
    {
        _customerDatabase = new ArrayList();
    }
    #endregion
    
    #region Fields/Properties
    // Fields-Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    #endregion

    #region Encapsulation
    private string _username;
    public string Username
    {
        get => _username;
        set
        {
            bool usernameControl = CustomerUsernameControl(value);
            if (usernameControl)
            {
                Console.WriteLine("The username already taken.");
                _username = string.Empty;
            }
            else
            {
                _username = value;
            }
        }
    }
    #endregion

    #region Static Methods

    private static bool CustomerUsernameControl(string username)
    {
        bool flag = false;
        for (int i = 0; i < _customerDatabase.Count; i++)
        {
            Customer temp = (Customer)_customerDatabase[i];
            if (temp.Username == username)
            {
                flag = true;
            }
        }
        return flag;
    }

    public static void AddACustomer(Customer m)
    {
        #region Parameter Control
        if (m != null && !string.IsNullOrEmpty(m.Username) && !string.IsNullOrEmpty(m.Email))
        {
            bool flag = CustomerEmailAddressControl(m.Email);
            if (flag)
            {
                Console.WriteLine("User already in our system.");   
            }
            else
            {
                _customerDatabase.Add(m);
                Console.WriteLine("New customer added.");
            }
        }
        #endregion
    }


    static bool CustomerEmailAddressControl(string emailAddress)
    {
        bool flag = false;
        for (int i = 0; i < _customerDatabase.Count; i++)
        {
            Customer temp = (Customer)_customerDatabase[i];
            if (temp.Email == emailAddress)
            {
                flag = true;
                break;
            }
        }

        return flag;
    }
    #endregion

}