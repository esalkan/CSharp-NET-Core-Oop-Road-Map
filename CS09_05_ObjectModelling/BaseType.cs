using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_05_ObjectModelling
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
        }
        #endregion
    }
}
