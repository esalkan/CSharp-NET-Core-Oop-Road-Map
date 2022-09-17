namespace CS07_03_Static_Field_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesne örneği oluşturma.
            // Object instantiation.
            Employee employee1 = new Employee();
            employee1.Name = "Badi";
            employee1.LastName = "Ekrem";
            employee1.EmailAddress = "badi.ekrem";
            employee1.Gender = 717770001;   // Man -> 717770002
        }
    }
}