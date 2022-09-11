namespace CS06_02_Data_Encapsulation;

internal class Customer
{
    // Constructor Method | Yapıcı Metot(Yöntem)
    public Customer()
    {
        this.id = IDGenerate();
    }
    
    /*
     * Class
     *  - Field
     *  - Property
     *  - Get & Set
     */

    #region Class Fields | Sınıf Alanları
    // Class Fields. | Sınıf Alanları.
    public int id;                  // Public
    public string name;             // Public
    public string surname;          // Public
    private string emailAddress;    // Private
    private string tcIdentityNumber;   // Private
    #endregion

    #region Class Properties | Sınıf Özellikleri
    // Class Properties | Sınıf Özellikleri
    //----------------------------------------------------
    // Declared a EmailAdress property of type string:
    // string türünde bir EmailAdress özelliği tanımlandı:
    #region The value can be assigned and the assigned value can be read. | Değer ataması yapılabilir ve atanan değer okunabilir.
    /*
     * Example;
     *  - The value can be assigned and the assigned value can be read.
     *  - Değer ataması yapılabilir ve atanan değer okunabilir.
     */
    public string EmailAddress
    {
        // Getting data... (for use getting data.)
        get
        {
            return this.emailAddress;
        }   
        // Setting data... (Which data set by developer)
        set
        {
            this.emailAddress = value;
        }
    }

    #endregion
    
    #region Field value cannot be assigned and the assigned value can be read. |  Field değer ataması yapılamasın ve atanan değer okunabilsin.
    /*
     * Example;
     *  - Field value cannot be assigned and the assigned value can be read.
     *  - Field değer ataması yapılamasın ve atanan değer okunabilsin.
     */
    public int ID
    {
        get // Field value can be assigned
        {
            return this.id;
        }
        private set // Field value CAN NOT be assigned
        {
            this.id = value;
        }
    }

    private int IDGenerate()
    {
        Random Rnd = new Random();
        return Rnd.Next(10000, 90000);
    }

    #endregion

    #region In the class, it is possible to assign a value to the field, but the first 4 digits of the value can be read. | Class içerisinde, field'a değer ataması yapılabilsin ama değerin ilk 4 hanesi okunabilsin

    public string TcIdentityNumber
    {
        get
        {
            return this.tcIdentityNumber.Substring(0,4);
        }
        set
        {
            if (value.Length == 11)
            {
                bool flag = false;
                for (int i = 0; i < value.Length; i++)
                {
                    bool charControl = char.IsNumber(value[i]);
                    if (!charControl)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine("The entered values must contains Digits.");
                }
                else
                {
                    this.tcIdentityNumber = value;
                }
            }
            else
            {
                Console.WriteLine("The entered value must be 11 digits.");
                Console.WriteLine("Girilen değer 11 hane olmalıdır.");
            }
        }
    }

    #endregion
    
    
    #endregion
    
    


}