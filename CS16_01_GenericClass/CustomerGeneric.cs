using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is our Generic Class | Bu bizim jenerik(genel) Sınıfımız.
namespace CS16_01_GenericClass
{
    //<T>: We specify that our class is generic. | Classımızın(Sınıfımızın) jenerik(Genel) olduğunu belirtiyoruz.
    public class CustomerGeneric<T> 
    {
        /*
         * Müşteri jenerik(Genel) sınıf'ı olarak, örneklendiğinde örneklendiğinde karşı tarafa bir soru sor. beni örneklemek istiyorsun ama, 
         * içeride bir T tipi var bu tipi doldur cünkü ben bunu kendi sınıfım içerisinde kullanma ihtimalim var. Bu bana yazılmış ben bir jenerik(Genel) sınıfım. 
         * beni örneklemek istiyorsan "T" tipini belirtmek zorundasın diye aslında nesnemizi örnekleyecek olan kişiye bir soru soruyoruz ve "T" tipimizi aşağıda belirlediğimiz 
         * fields (Alanlar) kısmına bakarak görebiliriz.
         * 
         * Ask a question when the client generic class is instantiated. You want to exemplify me, but inside there is a type T fill this type because I have the possibility to use it in my class.
         * This is a generic class written for me. If you want to exemplify me, you have to specify the T type. In fact, we ask the person who will instantiate our object, 
         * and we can see our T type by looking at the fields we set below.
         * 
         * 
         * Ne demek "T" tipi; artık benim müşteri jenerik sınıfımı örnekleyen kişi, o "T" tipine ne yazarsa, müşteri jenerik nesnesi örneklendiğinde Müşteri numarası field'i(Alan/alanları) 
         * "T" tipinin içerisinde barındırdığı veri tipinde olsun demek.
         * 
         * What does "T" type mean? Now, whatever the person who instantiated my customer generic class writes to that T type, when the customer generic object is instantiated, 
         * the Customer number field should be of the data type contained in the T type.
         */
        public T id { get; set; }
        public T customerNumber { get; set; }
        public string socialSecurityNumber { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime birthDate { get; set; }

        public T getCustomerNumber()
        {
            return customerNumber;
        }
    }
}
