using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_09_ExerciseProject
{
    public class BaseClass
    {
        public static int counter = 1; // It will automatically take the value 1 the first time it instantiated.

        public BaseClass()
        {
            _ID = counter;
            counter = counter + 1;
        }
        private int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
            private set
            {
                // The set field is marked as private, cannot be set. To fix this, we do the operation in the constructor.
                //_ID = counter;
                //counter = counter + 1;
            }
        }
        private string _Barcode;
        public string Barcode
        {
            get
            {
                return _Barcode;
            }
            set 
            {
                bool controlFlag = virtualDatabase.dbBarcodeControl(value);

                if (!controlFlag)
                {
                    _Barcode = value;
                }
                else
                {
                    Console.WriteLine("Barcode already generated before.");
                }
            }
        } // If barcode is already generated and saved to the database, return an message.

        public int creator_user_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool isDeleted { get; set; }
    }
}
