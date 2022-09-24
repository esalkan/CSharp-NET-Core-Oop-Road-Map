namespace CS08_02_InnerType_Modeling;

public class CustomerAddress
{
    #region Constructor|Yapıcı Method
    // Constructor Method
    // Yapıcı Metot
    public CustomerAddress()
    {
        Console.WriteLine("Customer Address Constructor Method Ran.");
    }

    #endregion

    #region Fields|Properties - Alanlar|Özellikler
    public string AddressType { get; set; }
    public string Province { get; set; }
    public string District { get; set; }
    public string Address { get; set; }
    #endregion

    #region Custom Methods | Özel Metotlar

    public void CustomerAddressTestMethod()
    {
        Console.WriteLine("This is a Custom method name is CustomerAddressTestMethod() in CustomerAddress Class");
    }

    #endregion
    
}