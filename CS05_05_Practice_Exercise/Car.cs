namespace CS05_05_Practice_Exercise;

public class Car
{
    #region Fields

    public string Brand;
    public string Model;
    public int ModelYear;
    public int Km;
    public string FuelType;
    public string GearType;
    public decimal BuyingPrice;
    public decimal SellingPrice;
    public int MaxDiscountPrice;
    public decimal Price;

    #endregion

    #region Constructors

    public Car()
    {
        
    }

    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public Car(string brand, string model, int modelYear)
    {
        Brand = brand;
        Model = model;
        ModelYear = modelYear;
    }

    public Car(string brand, string model, int modelYear, int km)
    {
        Brand = brand;
        Model = model;
        ModelYear = modelYear;
        Km = km;
    }

    public Car(string brand, string model, int modelYear, int km, string fuelType)
    {
        Brand = brand;
        Model = model;
        ModelYear = modelYear;
        Km = km;
        FuelType = fuelType;
    }

    public Car(string brand, string model, int modelYear, int km, string fuelType, string gearType)
    {
        Brand = brand;
        Model = model;
        ModelYear = modelYear;
        Km = km;
        FuelType = fuelType;
        GearType = gearType;
    }

    public Car(string brand, string model, int modelYear, int km, string fuelType, string gearType, decimal buyingPrice)
    {
        Brand = brand;
        Model = model;
        ModelYear = modelYear;
        Km = km;
        FuelType = fuelType;
        GearType = gearType;
        BuyingPrice = buyingPrice;
    }

    public Car(string brand, string model, int modelYear, int km, string fuelType, string gearType, decimal buyingPrice, decimal sellingPrice)
    {
        Brand = brand;
        Model = model;
        ModelYear = modelYear;
        Km = km;
        FuelType = fuelType;
        GearType = gearType;
        BuyingPrice = buyingPrice;
        SellingPrice = sellingPrice;
    }

    public Car(string brand, string model, int modelYear, int km, string fuelType, string gearType, decimal buyingPrice, decimal sellingPrice, int maxDiscountPrice)
    {
        Brand = brand;
        Model = model;
        ModelYear = modelYear;
        Km = km;
        FuelType = fuelType;
        GearType = gearType;
        BuyingPrice = buyingPrice;
        SellingPrice = sellingPrice;
        MaxDiscountPrice = maxDiscountPrice;
    }

    public Car(string brand, string model, int modelYear, int km, string fuelType, string gearType, decimal buyingPrice, decimal sellingPrice, int maxDiscountPrice, decimal price)
    {
        Brand = brand;
        Model = model;
        ModelYear = modelYear;
        Km = km;
        FuelType = fuelType;
        GearType = gearType;
        BuyingPrice = buyingPrice;
        SellingPrice = sellingPrice;
        MaxDiscountPrice = maxDiscountPrice;
        Price = price;
    }

    #endregion

    #region Methods

    public void ViewInformations()
    {
        Console.WriteLine($"Brand : {Brand}\nModel : {Model}\nModel Year : {ModelYear}\nKm : {Km}\nFuel Type : {FuelType}\nGear Type : {GearType}\nBuying Price : {BuyingPrice}\nSelling Price : {SellingPrice}\nMaximum Discount Price : {MaxDiscountPrice}\nPrice : {Price} ₺");
    }

    public void AssignPrice(decimal price)
    {
        decimal calculatePrice = SellingPrice - MaxDiscountPrice;
        
        if (price < calculatePrice)
        {
            Console.WriteLine("Invalid Price Entry!\nGeçersiz Fiyat Girişi!");
        }
        else
        { 
            this.Price = price;
        }
    }

    #endregion
}