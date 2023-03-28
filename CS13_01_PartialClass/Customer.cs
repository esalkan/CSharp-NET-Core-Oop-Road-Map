using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS13_01_PartialClass
{
    public class Customer
    {
        #region Fields
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        #endregion

        #region Methods
        public int create(Customer c)
        {
            Console.WriteLine("New record is saved into the DB");
            return 1;
        }

        public int update(Customer c)
        {
            Console.WriteLine("The customer data is updated.");
            return 1;
        }

        public int delete(int customerID)
        {
            Console.WriteLine("The customer is deleted.");
            return 1;
        }
        #endregion
    }
}
