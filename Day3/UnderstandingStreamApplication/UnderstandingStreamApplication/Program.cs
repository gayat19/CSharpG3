using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnderstandingStreamApplication
{
    class Program
    {
        string filePath = @"C:\Users\gayat\OneDrive\Desktop\Daily\File1.txt";
        void ReadFileByte()
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fileStream);
            int position = 0;
            int length = (int)reader.BaseStream.Length;
            byte[] dataCollection = new byte[length];
            int returenedByte;
            while ((returenedByte = reader.Read()) != -1)
            {
                dataCollection[position] = (byte)returenedByte;
                Console.WriteLine(dataCollection[position]);
                position += sizeof(byte);
            }
            reader.Close();
            fileStream.Close();
        }
        void ReadFileString()
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            StringBuilder fileData = new StringBuilder();
            
            while (reader.Peek() != -1)
            {
                fileData.Append((char)reader.Read());
            }
            string fileString = fileData.ToString();
            Console.WriteLine(fileString);
            reader.Close();
            fileStream.Close();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ReadFileString();
            Console.ReadKey();
        }
    }
}
