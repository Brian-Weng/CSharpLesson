using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\CSharp\\";
            //string path = "Fake\\";
            string fileName = "AAA.txt";
            string dirName = "ccc";
            //string content = TestFileReader.ReadFile(path + fileName);
            //Console.WriteLine(content);
            //string content = "hello world";
            //TestFileReader.Append(path + fileName, content);
            //TestFolderReader.ListAllFile(path);
            TestFolderReader.CreateFolder(path + dirName);
            Console.Read();
        }
    }
}
