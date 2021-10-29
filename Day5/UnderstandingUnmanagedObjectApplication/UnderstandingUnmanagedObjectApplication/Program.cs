using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Office.Interop.Word;

namespace UnderstandingUnmanagedObjectApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = ConfigurationManager.AppSettings["filePath"];
            dynamic word = new Application();//Creates an Instance of Word application
            dynamic doc = word.Documents.Add();//Adds a new document
            doc.Activate();//make the new document as teh active document
            word.Visible = true;
            var myLocation = doc.Range(doc.Content.End -1);
            bool bold = true;
            bool Underline = true;
            //Console.WriteLine("Please enter the data to be written");
            //string data = Console.ReadLine();
            string data = "Hello word!!!!";
            myLocation.Bold = bold?1:0;
            myLocation.Underline = Underline ? WdUnderline.wdUnderlineSingle : WdUnderline.wdUnderlineNone;
            myLocation.InsertAfter(data);
            doc.SaveAs(filePath);
            word.Quit();
            word = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}
