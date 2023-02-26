using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_09_ExerciseProject
{
    public static class virtualDatabase
    {
        private static ArrayList db = new ArrayList();

        public static void addNewProduct(BaseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.Barcode))
            {
                db.Add(data);
            }
        }

        public static bool dbBarcodeControl(string barcode)
        {
            bool controlFlag = false;

            if (db != null && db.Count > 0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    BaseClass baseClass = (BaseClass)db[i];
                    if (baseClass.Barcode == barcode)
                    {
                        // return true;
                        controlFlag = true; 
                    }
                }
            }
            // return false;
            return controlFlag;
        }
    }
}
