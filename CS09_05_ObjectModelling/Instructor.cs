﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_05_ObjectModelling
{
    public class Instructor : BaseType
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
