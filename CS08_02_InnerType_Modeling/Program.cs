namespace CS08_02_InnerType_Modeling
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creating a Customer Instance
            // Creating a Customer instance
            Customer c1 = new Customer();
            c1.CustomerId = 1;
            c1.NationalIdCardNumber = "123456789101";
            c1.Name = "Banker";
            c1.Surname = "BILO";
            c1.CreationDate = DateTime.Now;

            #region Using Inner Type
            // c1.CustomerAddresses = new CustomerAddress[5]; // Never ever do that
            c1.CustomerAddresses[0] = new CustomerAddress()
            {
                AddressType = "Business",
                Province = "Istanbul",
                District = "Beyoglu",
                Address = "Taksim..."
            };
            #endregion

            #region Calling Inner Type Methods
            // Console.WriteLine(c1.CustomerAddresses[0].AddressType);
            // Console.WriteLine(c1.CustomerAddresses[0].Province);
            // Console.WriteLine(c1.CustomerAddresses[0].District);
            // Console.WriteLine(c1.CustomerAddresses[0].Address);
            // Calling inner type method
            c1.CustomerAddresses[0].CustomerAddressTestMethod();
            #endregion

            #region Customer Product inner type

            c1.CustomerOrderInformations[0] = new CustomerOrderInformation()
            {
                OrderNumber = "1"
            };
            
            c1.CustomerOrderInformations[0].Products[0] = new Product()
            {
                ProductId = 1,
                ProductName = "Phone",
                ProductPrice = 27000m
            };


            #endregion

            #endregion
        }
    }
}