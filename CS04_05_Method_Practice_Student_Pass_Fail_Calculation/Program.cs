namespace CS04_05_Method_Practice_Student_Pass_Fail_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentStatus std = new StudentStatus();
            
            string studentName, studentSurname;
            decimal visa, final;

            std.Message();

            Console.WriteLine("Please enter your name : ");
            studentName = Console.ReadLine();
            Console.WriteLine("Please enter your surname");
            studentSurname = Console.ReadLine();
            
            Console.WriteLine("Please Enter your visa exam score :");
            visa = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Please Enter your final exam score :");
            final = decimal.Parse(Console.ReadLine());

            std.PassOrFail(studentName, studentSurname, visa, final);
        }
    }
}