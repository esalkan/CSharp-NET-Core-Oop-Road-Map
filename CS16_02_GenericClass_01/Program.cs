using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS16_02_GenericClass_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Database   | Application
             * MSSQL      |  C#
             * 
             * tblCustomer
             *  - id: int
             *  - customerNumber: uniqueIdentify = (Guid)
             *  - name: nvarchar(50) = String
             *  - surname: nvarchar(50) = String
             *  - birthDay: DateTime = DateTime
             *  
             *  Design Pattern
             *  UnitOfWorks => Generic Class | Generic Interface | 
             * 
             */

            // Müşteri class'ını GenericRepository'e T tipi olarak verdik. | We have given the client class to GenericRepository as T type.
            GenericRepository<Customer> repositoryCustomer = new GenericRepository<Customer>();
            
            // The Bring method is not get a parameter, but it says "i can return List<Customer> generic object".
            List<Customer> customers = repositoryCustomer.Bring();
            repositoryCustomer.addNewRecord(null);


            GenericRepository<Product> productRepository = new GenericRepository<Product>();
            List<Product> products = productRepository.Bring();
            productRepository.addNewRecord(null);

        }
    }
}
