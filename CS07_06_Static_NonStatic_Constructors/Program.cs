namespace CS07_06_Static_NonStatic_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            // Firstly Static Constructor will run in employee class.
            // Secondly Non-static Constructor will run in employee class.
            Employee employee1 = new Employee();
            employee1.Name = "Badi";
            employee1.LastName = "Ekrem";
            employee1.EmailAddress = "badi.ekrem";
            employee1.Gender = 717770001;
            

            // Non-Static Constructor will run in employee class...
            // Static Constructor already run in first run and it will not run again.
            Employee employee2 = new Employee();
            employee2.Name = "Güdük";
            employee2.LastName = "Necmi";
            employee2.EmailAddress = "guduk.necmi";
            employee2.Gender = 717770001;
            
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