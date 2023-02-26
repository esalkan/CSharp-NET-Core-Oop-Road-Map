using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_07_InheritanceWithinTheObject
{
    // Sealed Class
    // This object is public and can be accessed externally.
    // But sealed and this object cannot be instantiated.
    public sealed class Instructor : Staff
    {
        #region Fields/Properties | Alanlar/Özellikler
        public string Branch { get; set; }
        public int BranchLevel { get; set; }
        #endregion

        #region Constructor Method | Özel Metodlar
        public Instructor()
        {
            Console.WriteLine("Instructor Object Constructor method is RUN.");
        }
        #endregion
    }
}
