namespace CS07_05_Static_Class_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Employee employee1 = new Employee();
            employee1.Name = "Badi";
            employee1.LastName = "Ekrem";
            employee1.EmailAddress = "badi.ekrem";
            employee1.Gender = 717770001;
            
            // Helper Class created.
            // sendEmail static method created and used.
            Helper.sendEmail("hr@company.com","New Employee",employee1.Name + employee1.LastName);
            
            // Static Class Usage
            Helper.sendEmail("hr@company.com","New Employee",employee1.Name + employee1.LastName);
            /*
             * Static Constructor will run first, as we can see above we call static method 2 times.
             * And we will see just one console output.
             *
             * Önce Static Constructor çalışacaktır, yukarıda gördüğümüz gibi static methodu 2 defa çağırıyoruz.
             * Ve sadece bir konsol çıktısı göreceğiz.
             *
             * Console Output/Çıktı:
             *      Helper.cs => Static Class => Static Constructor
             */
        }
    }
}