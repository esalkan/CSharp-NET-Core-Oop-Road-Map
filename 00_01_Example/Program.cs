using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01_Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * C klasörü içerisinde Example_001 adında bir klasör oluşturalım. 
             * Önce varlık kontrolü yapalım, eğer klasör var ise silelim ve klasörü oluşturalım. 
             * Eğer yok ise klasörü oluşturalım.
             * Bu adımların bilgisini ekrana yazdıralım.
             */

            string directoryName = @"C:\Example_001";

            Create_Directory(directoryName);
        }

        public static bool Check_Directory(string path)
        {
            Console.WriteLine("Check Directory method works.");
            bool directoryCheck = Directory.Exists(path);
            return directoryCheck;
        } 


        public static void Delete_Directory(string path)
        {
            Console.WriteLine("Delete directory method works.");
            Directory.Delete(path);
        }

        public static void Create_Directory(string path)
        {
            Console.WriteLine("Create Directory method works.");

            Console.WriteLine("Check Directory medhod called.");
            bool isDirectoryExist = Check_Directory(path);
            
            if (isDirectoryExist)
            {
                Console.WriteLine("The directory Exist and program deleting the directory");
                Delete_Directory(path);
                Console.WriteLine("The Directory Deleted and creating directory again...");
                Directory.CreateDirectory(path);
            }
            else
            {
                Console.WriteLine("The directory is not exist and the program creating the directory in " + path);
                Directory.CreateDirectory(path);
            }
        }
    }
}
