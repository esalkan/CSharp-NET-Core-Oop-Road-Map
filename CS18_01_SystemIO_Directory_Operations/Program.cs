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
            string path = @"C:\MePlayGround\GitHubRepos\CSharp\Directory";
            string destinationPath = @"C:\MePlayGround\Directory";
            // Yeni klasör oluşturma.
            // Creating new folder.
            Create_Directory(path);

            // Klasör varlık kontrolü. (Var olup olmadığını kontrol ediyoruz.)
            // The folder existance control.
            Check_Directory(path);

            // Klasör silme işlemi.
            // Delete folder operation.
            Delete_Directory(path);

            // Klasör taşıma
            // Move Directory
            Create_Directory(path);
            Move_Directory(path, destinationPath);
        }

        // Yeni klasör oluştur metodu.
        // Create new folder method.
        static void Create_Directory(string path)
        {
            // The Directory class actually allows us to perform folder operations on the hard disk.
            // Directory sınıfı bizim aslında sabit disk üzerinde klasör işlemleri yapmamıza olanak sağlar.
            DirectoryInfo DI= Directory.CreateDirectory(path);
        }

        // Klasör varlık kontrolü. (Var olup olmadığını kontrol ediyoruz.)
        // The folder existance control.
        static void Check_Directory(string path)
        {
            bool control = Directory.Exists(path);
        }

        // Yolu verilen klasörün silme işlemini gerçekleştirir.
        // Deletes the folder to which the path is given.
        static void Delete_Directory(string path)
        {
            // İçerisinde dosya OLMAYAN bir klasörü siler.
            // Deletes the folder wich is NOT HAVE any files.
            Directory.Delete(path);

            // İçerisinde dosya OLAN bir klasörü siler.
            // Deletes the folder wich is HAVE any files.
            // Directory.Delete(path, true);
        }

        // Yolu verilen var olan klasörü, yolu verilen hedef noktaya taşır.
        // Moves an existing folder to the destination point given the path.
        static void Move_Directory(string path, string destinationPath)
        {
            Directory.Move(path,destinationPath);
        }

    }
}
