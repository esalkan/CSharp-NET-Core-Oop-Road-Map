namespace CS08_02_InnerType_Modeling;

public class CustomerContactInformation
{
    #region Fields|Properties

    public int ContactType { get; set; } // 717770001 : Mobile Phone, 717770002 : Landline Phone
    public string AreaCode { get; set; }
    public string PhoneNumber { get; set; }
    public bool ActivePassive { get; set; }

    #endregion
    
    #region Custom Methods

    public void CustomerContactInformationTestMethod()
    {
        Console.WriteLine("This is a Custom method named CustomerContactInformationTestMethod() in CustomerContactInformation Class");
    }

    #endregion
}