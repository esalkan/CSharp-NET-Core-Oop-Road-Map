namespace CS09_04_Boxing_Unboxing;

public class Instructor : BaseTypes
{
    #region Fields/Properties

    public string Branch { get; set; }
    public int BranchLevel { get; set; }
    public DateTime JobStartDate { get; set; }
    public DateTime JobEndDate { get; set; }
    public int LeaveDays { get; set; }

    #endregion

    #region Constructor Method

    public Instructor()
    {
        Console.WriteLine("Instructor Object Constructor method is run.");
    }

    #endregion
}