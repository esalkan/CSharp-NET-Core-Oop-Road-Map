namespace CS05_03_Constructor_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Id = "11122233444";
            c1.name = "Customer 1";
            c1.surname = "C1Surname";
            c1.gender = 717770001;
            Console.WriteLine($"Customer 1 (c1) Informations\nID : {c1.Id}\nName : {c1.name}\nSurname : {c1.surname}\nGenger : {c1.gender}");

            Console.WriteLine();
            
            Customer c2 = new Customer("22233344555", "Customer 2");
            Console.WriteLine($"Customer 2 (c2) Informations\nID : {c2.Id}\nName : {c2.name}");
            
            Console.WriteLine();
            
            Customer c3 = new Customer("33344455666", "Customer 3", "C3Surname");
            Console.WriteLine($"Customer 3 (c3) Informations\nID : {c3.Id}\nName : {c3.name}\nSurname : {c3.surname}");
            
            Console.WriteLine();
            
            Customer c4 = new Customer("01234567890", "Customer 4", "C4Surname", 717770001);
            Console.WriteLine($"Customer 4 (c4) Informations\nID : {c4.Id}\nName : {c4.name}\nSurname : {c4.surname}\nGender : {c4.gender}");
        }
    }
}