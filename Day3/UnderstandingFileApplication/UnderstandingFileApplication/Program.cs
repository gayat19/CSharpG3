using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnderstandingFileApplication
{
    class Program
    {
        string path = @"C:\Users\gayat\OneDrive\Desktop\Daily";
        void WriteToFile()
        {
            string filePath = path + @"\Names.txt";
            if(File.Exists(filePath))
            {
                FileInfo file = new FileInfo(filePath);
                Console.WriteLine(file.DirectoryName);
                Console.WriteLine(file.Extension);
                Console.WriteLine(file.Name);
                Console.WriteLine(file.FullName);
                file.Delete();
            }
            string[] names = { "Rita", "Lim", "Jack" };
            File.WriteAllLines(filePath, names);
            Console.WriteLine("Done dana done");
        }
        void WorkWithDir()
        {
            var dirInfo = new DirectoryInfo(path);
            var files = dirInfo.GetDirectories();
            foreach (var item in files)
            {
                Console.WriteLine(item.Name);
            }
        }
        void ReadFromFile()
        {
            string filePath = path + @"\Names.txt";
            if(File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var item in lines)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("---------");
                }
            }
            else
                Console.WriteLine("No such file");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.WriteToFile();
            //program.ReadFromFile();
            program.WorkWithDir();
            Console.ReadKey();
        }
    }
}
