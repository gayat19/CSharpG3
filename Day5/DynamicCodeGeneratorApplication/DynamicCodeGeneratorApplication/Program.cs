using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCodeGeneratorApplication
{
    class Program
    {
        void GenetrateApplication()
        {
            var unit = new CodeCompileUnit();

            var dynamicNamespace = new CodeNamespace("FourthCoffee.Dynamic");
            unit.Namespaces.Add(dynamicNamespace);

            dynamicNamespace.Imports.Add(new CodeNamespaceImport("System"));

            var programType = new CodeTypeDeclaration("Program");
            dynamicNamespace.Types.Add(programType);

            var mainMethod = new CodeEntryPointMethod();
            programType.Members.Add(mainMethod);

            var expression = new CodeMethodInvokeExpression(
               new CodeTypeReferenceExpression("Console"), "WriteLine",
               new CodePrimitiveExpression("Hello Development Team..!!"));
            var provider = new CSharpCodeProvider();

            var fileName = "program.cs";
            var stream = new StreamWriter(fileName);
            var textWriter = new IndentedTextWriter(stream);

            var options = new CodeGeneratorOptions();
            options.BlankLinesBetweenMembers = true;

            //var compileUnit = new CodeCompileUnit();
            provider.GenerateCodeFromCompileUnit(
               unit,
               textWriter,
               options);

            textWriter.Close();
            stream.Close();
        }
        static void Main(string[] args)
        {
            new Program().GenetrateApplication();
            Console.ReadKey();
        }
    }
}
