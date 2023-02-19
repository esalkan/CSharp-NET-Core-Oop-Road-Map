namespace CS09_WhatIsInheritance;

public class BaseType
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
}