using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_05_ObjectModelling
{
    public class Staff : BaseType
    {
        #region Fields/Properties | Alanlar/Özellikler

        public DateTime JobStartDate { get; set; }
        public DateTime JobEndDate { get; set; }
        public int LeaveDays { get; set; }

        #endregion

        #region Constructor Method | Yapıcı Method

        public Staff()
        {
            Console.WriteLine("Staff object constructor method RUN");
        }

        #endregion
    }
}
