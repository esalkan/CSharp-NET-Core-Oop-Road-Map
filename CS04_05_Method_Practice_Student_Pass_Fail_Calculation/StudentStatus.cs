namespace CS04_05_Method_Practice_Student_Pass_Fail_Calculation;

public class StudentStatus
{
    /*
     * Kullanıcıdan
     *  Adını
     *  Soyadını
     *  3 Farklı Not değeri Al
     *
     * Vize
     * Final
     * Ortalama
     *      Ortalama 45 > Geçti
     *      Ortalama 45 < Kaldı
     *  
     */

    public void Message()
    {
        Console.Clear();
        Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
        Console.WriteLine("|This program calculates whether the student passed or not                                           |\n" +
                          "|by taking the student's name, surname, scores of 2 exams, calculating visa, final and average score.|");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------|");
        Console.WriteLine("|Bu program öğrencinin adını, soyadını, 2 sınav puanını alarak öğrencinin geçip olup geçemediğini,   |\n" +
                          "|vize, final ve not ortalamasını hesaplar.                                                           |");
        Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
    }

    private decimal AverageScore(decimal visa, decimal final)
    {
        decimal result = (visa + final) / 2;
        return result;
    }

    public void PassOrFail(string studentName, string studentSurname, decimal visa, decimal final)
    {
        if (AverageScore(visa, final) > 45)
        {
            Console.WriteLine($"Congragulation {studentName} {studentSurname}\nYour average score is {AverageScore(visa, final)} You PASS!");
        }
        else
        {
            Console.WriteLine($"Sorry {studentName} {studentSurname}\nYour average score is {AverageScore(visa, final)} You FAIL!");
        }
    }




}