using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS12_01_Interface
{
    // This is syntax rule, we always use for first letter Capital "I" for interfaces.
    // Bu bir sözdizimi kuralıdır, arayüzler için her zaman ilk harf Büyük "I" kullanırız.
    public interface ICustomer
    {
        /*
         * C# Interface is a concept that, by its nature, is a concept that is created to guide and guide
         * other classes, and that provides some properties that must be filled into a class that is 
         * implemented from it.
         * 
         * C# Interface, yapısı gereği diğer sınıflara yol gösterici, rehberlik yapmak için oluşturulan,
         * kendisinden implement edilen bir sınıfa doldurulması zorunlu olan bazı özelliklerin 
         * aktarılmasını sağlayan bir kavramdır.
         */

        #region We can not use Constructor methods in interface. 
        /*
         * public ICustomer()
         * {
         *      - We can not use Constructor methods in interface.
         *      - Interfacelerde yapıcı method kullanamayız.
         * }
         */
        #endregion

        /*
         * What an interface can contain.
         * Bir interface neleri bulundurabilir.
         * 
         *  - Fields
         *  - Methods
         *  - Delegates
         *  - etc..
         *  
         *  
         *  Interfacelerde hiç bir tanımın body'si olmaz, değişken tanımlanmaz
         */

        int Id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }

        int newRecord(string name, string lastName);
        int editRecord(int id, string name, string lastName);
        int deleteRecord(int id);

    }
}
