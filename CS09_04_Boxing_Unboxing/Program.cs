using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_04_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseTypes Bt = new BaseTypes();
            Bt.BaseTypeMethod1();

            Console.WriteLine();

            Instructor instructor1 = new Instructor();
            Console.WriteLine("The Instructor object is instantiated.");
            instructor1.BaseTypeMethod1();
            
            // Boxing and unboxing in special types
            
            // What is our Object?
            // BaseTypes is our Object
            BaseTypes Bt1;
            
            // Which objects act as base types object.
            // Staff, Instructor, Student
            // Because they derive from the "BaseTypes" object, the "BaseTypes" object behaves like an "Object" on these objects.
            
            // Boxing
            Bt1 = instructor1;  // We assigned the instructor object to the "BaseType" object.
            // Unboxing
            instructor1 = (Instructor)Bt1;
            
            // Boxing
            Staff staff1 = new Staff();
            Bt1 = staff1;       // We assigned the Staff object to the "BaseType" object.
            // Unboxing
            staff1 = (Staff)Bt1;
            
            // Boxing
            Student student1 = new Student();
            Bt1 = student1;     // We assigned the Student object to the "BaseType" object.
            // Unboxing
            student1 = (Student)Bt1;
            
            // Boxing - Unboxing
            object O1 = instructor1;        // Boxing
            instructor1 = (Instructor)O1;   // Unboxing
        }
    }
}