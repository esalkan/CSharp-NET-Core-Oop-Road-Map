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

            CreateNewFolder("C:\\MePlayGround\\GitHubRepos\\CSharp\\Directory");
        }

        static void CreateNewFolder(string path)
        {
            // The Directory class actually allows us to perform folder operations on the hard disk.
            // Directory sınıfı bizim aslında sabit disk üzerinde klasör işlemleri yapmamıza olanak sağlar.
            DirectoryInfo DI= Directory.CreateDirectory(path);
        }
    }
}
