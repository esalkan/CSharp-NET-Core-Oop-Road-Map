namespace CS09_09_ExerciseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance Scheme

            //                                      Computer Class
            // BaseClass    =>  Product Class   => 
            //                                      Television Class

            Computer computer1 = new Computer();
            // computer1.ID = 1; // We don't want to assign an id when the object is instantiated. We do not want the application to leave this area as settable. 
            computer1.brand = "HP";
            computer1.model = "ZBook";
            computer1.processor = "I9";
            computer1.buyingPrice = 0;
            computer1.sellingPrice = 13334M;
            computer1.campaignPrice = 12500M;
            computer1.Barcode = "1234567890";

            virtualDatabase.addNewProduct(computer1);

            Computer computer2 = new Computer();
            // computer1.ID = 1; // We don't want to assign an id when the object is instantiated. We do not want the application to leave this area as settable.
            computer2.brand = "HP";
            computer2.model = "ZBook";
            computer2.processor = "I9";
            computer2.buyingPrice = 0;
            computer2.sellingPrice = 13334M;
            computer2.campaignPrice = 12500M;
            computer2.Barcode = "1234567890";

            virtualDatabase.addNewProduct(computer2);

        }
    }
}