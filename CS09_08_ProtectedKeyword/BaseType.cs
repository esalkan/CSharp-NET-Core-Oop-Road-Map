using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_08_ProtectedKeyword
{
    public class BaseType
    {
        #region Fields/Properties | Alanlar/Özellikler
        public int Id { get; set; }
        public string ReferenceCode { get; set; }
        public string TcIdNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int RegisterUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUser { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Constructor Method | Yapıcı Method
        public BaseType()
        {
            Console.WriteLine("Base Types Object Constructor Method RUN");
            RandomIdGeneration();
        }
        #endregion

        #region Custom Methods | Özel Methodlar
        private void RandomIdGeneration()
        {
            Random random = new Random();
            this.Id = random.Next(1, 1000);
        }

        public void BaseTypeMethod1()
        {
            Console.WriteLine("Base Type => Method 1 RUN");

            // BaseTypeMethod2(); is protected, and it is behaving in the same class as private.
        }
        #endregion

        #region Protected Keyword
        // protected   : It behaves as private in normal usage. It means that it is used as public in another class by inheritance.
        protected void BaseTypeMethod2()
        {
            Console.WriteLine("Base Type => Protected => BaseTypeMethod() => is RUNNING");
        }
        #endregion
    }
}
