namespace CS08_02_InnerType_Modeling;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }

    public Product()
    {
        Console.WriteLine("Product Constructor Method Ran.");
    }

    public void ProductTestMethod()
    {
        Console.WriteLine("This is a Custom Method Named ProductTestMethod() in Product Class");
    }
}