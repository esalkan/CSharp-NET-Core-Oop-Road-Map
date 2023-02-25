using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_06_SealedKeyword
{
    public class Student : BaseType
    {
        #region Fields/Properties | Alanlar/Özellikler
        public string Department { get; set; }
        public int Grade { get; set; }
        #endregion

        #region Constructor Method | Yapıcı Method
        public Student()
        {
            Console.WriteLine("Student object constructor method RUN.");
        }
        #endregion
    }
}
