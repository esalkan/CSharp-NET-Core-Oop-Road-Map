using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_09_ExerciseProject
{
    public sealed class Computer : Product
    {
        public string processor { get; set; }
        public string randomAccessMemory { get; set; }
        public string displayCard { get; set; }
    }
}
