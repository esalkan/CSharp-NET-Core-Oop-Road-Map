using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS13_01_PartialClass
{
    public partial class Student
    {
        public int create(Student o)
        {
            Console.WriteLine("New record saved into the DB");
            return 1;
        }
        public int update(Student o)
        {
            Console.WriteLine("The record is updated");
            return 1;
        }
        public int delete(int id)
        {
            Console.WriteLine("The record deleted");
            return 1;
        }
    }
}
