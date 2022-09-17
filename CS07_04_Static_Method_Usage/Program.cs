namespace CS07_04_Static_Method_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Badi";
            employee1.LastName = "Ekrem";
            employee1.EmailAddress = "badi.ekrem";
            employee1.Gender = 717770001;
            
            // Helper Class created.
            // sendEmail static method created and used.
            Helper.sendEmail("hr@company.com","New Employee",employee1.Name + employee1.LastName);
            
        }
    }
}