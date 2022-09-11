namespace CS06_02_Data_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * OOP - Encapsulation - Data Encapsulation
             * 
             * In which situations can we use Encapsulation?
             * Example:
             *  - In the class, it is not possible to assign a value to the field, but it can read a value.
             *  - In the class, it is possible to assign a value to the field, but it can not read a value.
             *  - In the class, it is possible to assign a value to the field, but the first 4 digits of the value
             *    can be read.
             *  - In the class, it is possible to assign a value to the field and read it, but in these two operations,
             *    it must go through a process we specify and the data will be displayed later.
             * 
             * Kapsüllemeyi ne gibi durumlarda kullanabiliriz?
             * Örnek;
             *  - Class içerisinde, field'a değer ataması yapılamasın ama değer okuyabilsin.
             *  - Class içerisinde, field'a değer ataması yapılabilsin ama değer okuyamasın.
             *  - Class içerisinde, field'a değer ataması yapılabilsin ama değerin ilk 4 hanesi okunabilsin.
             *  - Class içerisinde, field'a değer ataması ve okuma işlemi yapılabilsin ama bu iki işlemde bizim
             *    belirlediğimiz bir süreçten geçsin ve veri daha sonra gösterilsin.
             */
            Console.Clear();
            #region The value can be assigned and the assigned value can be read. | Değer ataması yapılabilir ve atanan değer okunabilir.
            
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("The value can be assigned and the assigned value can be read. | Değer ataması yapılabilir ve atanan değer okunabilir.");
            Customer m1 = new Customer();
            m1.id = 54;
            m1.name = "Eyüp Sabri";
            m1.surname = "ALKAN";
            // m1.emailAdress = "me@esalkan.com"; // Private
            
            // Seting a value to the "private property"
            m1.EmailAddress = "me@esalkan.com";
            
            Console.WriteLine($"Customer Email Address : {m1.EmailAddress}");
            Console.WriteLine($"Customer Id Number : {m1.id}");

            #endregion

            #region Field value cannot be assigned and the assigned value can be read. |  Field değer ataması yapılamasın ve atanan değer okunabilsin.
            
            Console.WriteLine("\n------------------------------------------------------------------------------------");
            Console.WriteLine("Field value cannot be assigned and the assigned value can be read. |  Field değer ataması yapılamasın ve atanan değer okunabilsin.");
            Customer m2 = new Customer();
            Console.WriteLine($"Customer Id (Generated with Costructor) : {m2.id}");
            Console.WriteLine($"Customer Id (Generated with Costructor) : {m2.ID}");
            
            #endregion
            
            #region In the class, it is possible to assign a value to the field, but the first 4 digits of the value can be read. | Class içerisinde, field'a değer ataması yapılabilsin ama değerin ilk 4 hanesi okunabilsin
            
            Console.WriteLine("\n------------------------------------------------------------------------------------");
            Console.WriteLine("- In the class, it is possible to assign a value to the field, but the first 4 digits of the value can be read.");
            Console.WriteLine("- Class içerisinde, field'a değer ataması yapılabilsin ama değerin ilk 4 hanesi okunabilsin.");
            Customer m3 = new Customer();
            m3.TcIdentityNumber = "12345678910";
            string CustomerTC = m3.TcIdentityNumber;
            Console.WriteLine("First 4 digits : " + CustomerTC);
            
            #endregion

            #region In the class, it is possible to assign a value to the field and read it, but in these two operations, it must go through a process we specify and the data will be displayed later. | Class içerisinde, field'a değer ataması ve okuma işlemi yapılabilsin ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin ve veri daha sonra gösterilsin.

            Console.WriteLine("In the class, it is possible to assign a value to the field and read it, but in these two operations, it must go through a process we specify and the data will be displayed later.");
            Console.WriteLine("Class içerisinde, field'a değer ataması ve okuma işlemi yapılabilsin ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin ve veri daha sonra gösterilsin.");
            // "name" & "surname"
            // "name" ve "surname[surname"] = set
            // email address
            // email get email.address@mail.com
            // set : private
            Customer m4 = new Customer();
            m4.name = "Eyüp Sabri";
            m4.GenerateEmailAddressWithNameAndSurname = "ALKAN";
            string customerEmail = m4.EmailAddress;
            Console.WriteLine(customerEmail);

            #endregion
        }
    }
}