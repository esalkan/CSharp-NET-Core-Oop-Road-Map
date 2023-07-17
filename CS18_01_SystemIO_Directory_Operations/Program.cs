using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS18_01_SystemIO_Directory_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yeni klasör oluşturma.
            // Creating new folder.
            //CreateNewFolder("C:\\MePlayGround\\GitHubRepos\\CSharp\\Directory");
            
            // Klasör varlık kontrolü. (Var olup olmadığını kontrol ediyoruz.)
            // The folder existance control.
            CheckFolderExistance("C:\\MePlayGround\\GitHubRepos\\CSharp\\Directory");
        }

        // Yeni klasör oluştur metodu.
        // Create new folder method.
        static void CreateNewFolder(string path)
        {
            // The Directory class actually allows us to perform folder operations on the hard disk.
            // Directory sınıfı bizim aslında sabit disk üzerinde klasör işlemleri yapmamıza olanak sağlar.
            DirectoryInfo DI= Directory.CreateDirectory(path);
        }


        static void CheckFolderExistance(string path)
        {
            bool control = Directory.Exists(path);
        }
    }
}
