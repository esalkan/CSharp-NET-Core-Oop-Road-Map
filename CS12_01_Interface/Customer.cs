using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS12_01_Interface
{
    internal class Customer : ICustomer
    {
        int _id;
        string _name;
        string _lastName;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }

        public int deleteRecord(int id)
        {
            Console.WriteLine("Record Deleted...");
            return 1;
        }

        public int editRecord(int id, string name, string lastName)
        {
            Console.WriteLine("Record Edited...");
            return 1;
        }

        public int newRecord(string name, string lastName)
        {
            Console.WriteLine("Record Created...");
            return 1;
        }
    }
}