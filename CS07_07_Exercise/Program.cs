namespace CS07_07_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Badi";
            customer1.Surname = "Ekrem";
            customer1.Email = "badi.ekrem@mail.com";
            customer1.Username = "badi.ekrem";
            customer1.Password = "badi1";
            
            Customer.AddACustomer(customer1);

            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Güdük",
                Surname = "Necmi",
                Email = "guduk.necmi@mail.com",
                Username = "guduk.necmi",
                Password = "guduk1"
            };
            
            Customer customer3 = new Customer();
            customer3.Id = 1;
            customer3.Name = "Nasreddin";
            customer3.Surname = "Hoca";
            customer3.Email = "badi.ekrem@mail.com";
            customer3.Username = "badi.ekrem";
            customer3.Password = "badi1";

        }
    }
}