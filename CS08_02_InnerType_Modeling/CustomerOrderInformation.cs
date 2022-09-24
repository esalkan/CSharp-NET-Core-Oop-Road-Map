namespace CS08_02_InnerType_Modeling;

public class CustomerOrderInformation
{
    #region Constructors

    public CustomerOrderInformation()
    {
        Products = new Product[5];
    }

    #endregion
    #region Fields|Properties
    public string OrderNumber { get; set; }
    #endregion

    #region InnerType

    public Product[] Products;
    #endregion
    
    #region Custom Methods

    public void CustomerOrderInformationTestMethod()
    {
        Console.WriteLine("This is a Custom method Named : CustomerOrderInformationTestMethod() in CustomerOrderInformation Class");
    }

    #endregion
}