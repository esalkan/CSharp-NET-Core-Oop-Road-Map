namespace CS05_05_Practice_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car car1 = new Car("Opel", "Astra", 2011, 216000, "Benzin", "Manual", 210000, 250000, 240000);
            Car car1 = new Car("Opel","Astra");
            car1.ModelYear = 2011;
            car1.Km = 216000;
            car1.FuelType = "Benzin";
            car1.GearType = "Manual";
            car1.BuyingPrice = 28000;
            car1.SellingPrice = 32000;
            car1.MaxDiscountPrice = 1500;
            
            car1.AssignPrice(30000);
            
            car1.ViewInformations();
        }
    }
}