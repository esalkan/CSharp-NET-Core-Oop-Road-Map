namespace CS09_03_Accessing_Constructor_Methods;

public class BaseTypes
{
    #region Base Type Fields/Properties
    public int Id { get; set; }
    public string ReferenceCode { get; set; }
    public string TcIdNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Gender { get; set; }
    public DateTime RegistrationDate { get; set; }
    public int RegisterUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUser { get; set; }
    public bool IsDeleted { get; set; }
    #endregion

    #region Constructor Method
    public BaseTypes()
    {
        Console.WriteLine("Base Types Object Constructor Method Run");
        RandomIdGeneration();
    }
    #endregion

    #region Custom Methods
    private void RandomIdGeneration()
    {
        Random random = new Random();
        this.Id = random.Next(1, 1000);
    }

    public void BaseTypeMethod1()
    {
        Console.WriteLine("Base Type => Method 1");
    }
    #endregion
}