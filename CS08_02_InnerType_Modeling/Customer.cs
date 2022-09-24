using System.Collections;

namespace CS08_02_InnerType_Modeling;

public class Customer
{
    #region Constructor|Yapıcı Methods
    public Customer()
    {
        CustomerAddresses = new CustomerAddress[2];
        CustomerContactInformations = new CustomerContactInformation[3];
        CustomerOrderInformations = new CustomerOrderInformation[10];
    }

    #endregion
    
    #region Fiels|Properties - Alanlar|Özellikler
    public int CustomerId { get; set; }
    public string NationalIdCardNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime CreationDate { get; set; }
    public int UserId { get; set; }
    #endregion

    #region fields/properties that require "Inner Type"
    public CustomerAddress[] CustomerAddresses;
    public CustomerContactInformation[] CustomerContactInformations;
    public CustomerOrderInformation[] CustomerOrderInformations;
    #endregion
}