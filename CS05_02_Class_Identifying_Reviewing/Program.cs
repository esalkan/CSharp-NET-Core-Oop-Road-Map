namespace CS05_02_Class_Identifying_Reviewing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new Customer
            Customer c1 = new Customer();
            
            // Assigning values to the c1 Customer
            c1.TcID = "98765432109";
            c1.name = "Mete";
            c1.surname = "HAN";
            c1.gender = 717770001;

            Console.Clear();
            Console.WriteLine("Customer informations");
            Console.WriteLine($"ID : {c1.TcID}\nName : {c1.name}\nSurname : {c1.surname}\nGender : {c1.gender}");
        }
    }
}