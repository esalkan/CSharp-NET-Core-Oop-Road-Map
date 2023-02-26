using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_09_ExerciseProject
{
    public sealed class Television : Product
    {
        public bool isSmartTv { get; set; }
        public bool isHaveHDMI { get; set; }
        public string screenSize { get; set; }

    }
}