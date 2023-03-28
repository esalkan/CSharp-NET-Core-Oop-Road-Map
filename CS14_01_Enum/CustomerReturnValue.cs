using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS14_01_Enum
{
    /*
     * Enum (Enumaration)Bu yapı yazılım dilinde enum, enumaration ya da enum sabitleri olarak adlandırılır. 
     * Değişkenlerin alabileceği değerlerin sabit (belli) olduğu durumlarda programı daha okunabilir hale 
     * getirmek için kullanılır. Programda birçok değişkene tek tek sayısal değer vermek yerine "enum" 
     * kullanılabilir. Özet olarak "enum" yapısı sayıları anlamlı şekilde isimlendirerek kullanabilmeye izin 
     * verir.
     * 
     * Enum (Enumation)This structure is called enum, enumration or enum constants in the software language. 
     * It is used to make the program more readable when the values that the variables can take are fixed 
     * (certain). Instead of giving numerical values to many variables one by one, "enum" can be used in the 
     * program. In summary, the "enum" structure allows to use numbers by naming them meaningfully.
     */
    public enum CustomerReturnValue
    {
        RegistrationSuccessful = 000000001,
        RegistrationFailed = 000000002,
        ExistingRecord = 000000003,
        ParameterError = 000000004,
        RunTimeError = 000000005
    }
}
