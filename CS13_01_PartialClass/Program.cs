using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS13_01_PartialClass
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Non Partial Class Fields and Methods and Their Behaviors
            Customer c1 = new Customer();
            c1.id = 1;
            c1.name = "John";
            c1.lastName = "DOE";
            c1.email = "john.doe@cloud.com";

            int result = c1.create(c1);

            if (result > 0)
            {
                Console.WriteLine("New user added into the DB");
            }

            // ----------o----------o----------o----------o----------o----------

            Student s1 = new Student();
            s1.id = 1;
            s1.name = "John";
            s1.lastName = "DOE";
            s1.studentNumber = "123456789";

            s1.create(s1);


        }
    }
}
