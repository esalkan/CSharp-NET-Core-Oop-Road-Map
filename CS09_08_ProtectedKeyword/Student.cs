using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_08_ProtectedKeyword
{
    public sealed class Student : BaseType
    {
        #region Fields/Properties | Alanlar/Özellikler
        public string Department { get; set; }
        public int Grade { get; set; }
        #endregion

        #region Constructor Method | Yapıcı Method
        public Student()
        {
            Console.WriteLine("Student object constructor method RUN.");
            // We are calling protected BaseTypeMethod2()
            // How we can call it? Because Student Class inherited from BaseType Class.
            BaseTypeMethod2(); 
        }
        #endregion
    }
}
