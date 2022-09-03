namespace CS04_03_Defining_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.SM_Greeting();
            Console.WriteLine();
            std1.SM_Name_Surname("İnek", "Şaban");
            Console.WriteLine();
            std1.SM_Call_Private_Name_Surname_Method();
        }
    }
}