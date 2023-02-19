namespace CS09_WhatIsInheritance;

public class Instructor : BaseType
{
    #region Fields/Properties

    public string Branch { get; set; }
    public int BranchLevel { get; set; }
    public DateTime JobStartDate { get; set; }
    public DateTime JobEndDate { get; set; }
    public int LeaveDays { get; set; }

    #endregion
}