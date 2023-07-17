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
            CreateNewFolder("C:\\MePlayGround\\GitHubRepos\\CSharp\\Directory");

            // Klasör varlık kontrolü. (Var olup olmadığını kontrol ediyoruz.)
            // The folder existance control.
            CheckFolderExistance("C:\\MePlayGround\\GitHubRepos\\CSharp\\Directory");

            // Klasör silme işlemi.
            // Delete folder operation.
            DeleteFolder("C:\\MePlayGround\\GitHubRepos\\CSharp\\Directory");
        }

        // Yeni klasör oluştur metodu.
        // Create new folder method.
        static void CreateNewFolder(string path)
        {
            // The Directory class actually allows us to perform folder operations on the hard disk.
            // Directory sınıfı bizim aslında sabit disk üzerinde klasör işlemleri yapmamıza olanak sağlar.
            DirectoryInfo DI= Directory.CreateDirectory(path);
        }

        // Klasör varlık kontrolü. (Var olup olmadığını kontrol ediyoruz.)
        // The folder existance control.
        static void CheckFolderExistance(string path)
        {
            bool control = Directory.Exists(path);
        }

        // Yolu verilen klasörün silme işlemini gerçekleştirir.
        // Deletes the folder to which the path is given.
        static void DeleteFolder(string path)
        {
            // İçerisinde dosya OLMAYAN bir klasörü siler.
            // Deletes the folder wich is NOT HAVE any files.
            Directory.Delete(path);

            // İçerisinde dosya OLAN bir klasörü siler.
            // Deletes the folder wich is HAVE any files.
            // Directory.Delete(path, true);
        }
    }
}
