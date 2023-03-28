using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS14_01_Enum
{
    public class VirtualDatabase
    {
        ArrayList virtualDB = new ArrayList();

        //public int newCustomerCreate(Customer C)
        //{
        //    virtualDB.Add(C);
        //    return 000000001;
        //}

        public CustomerReturnValue newCustomerCreate(Customer C)
        {
            // Parameter Control
            // etc....
            
            // Record Control 
            virtualDB.Add(C);
            return CustomerReturnValue.RegistrationSuccessful;
        }
    }

}
