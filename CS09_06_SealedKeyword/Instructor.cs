using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_06_SealedKeyword
{

    // Sealed Class
    // This object is public and can be accessed externally.
    // But sealed and this object cannot be instantiated.
    public sealed class Instructor : BaseType
    {
        #region Fields/Properties | Alanlar/Özellikler
        public string Branch { get; set; }
        public int BranchLevel { get; set; }
        public DateTime JobStartDate { get; set; }
        public DateTime JobEndDate { get; set; }
        public int LeaveDays { get; set; }
        #endregion

        #region Constructor Method | Özel Metodlar

        public Instructor()
        {
            Console.WriteLine("Instructor Object Constructor method is RUN.");
        }

        #endregion
    }
}
