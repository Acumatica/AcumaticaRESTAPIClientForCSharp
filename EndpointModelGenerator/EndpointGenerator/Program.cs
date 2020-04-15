using EndpointSchemaGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndpointGenerator
{
	class Program
    {
        const string OutputDirectoryTemplate = @"\Acumatica.{0}";
        const string EndpointSchemaDirectory = @"\EndpointDefinitions\";
        const string DefaultNamespaceTemplate = @"Acumatica.{0}";

        static void Main(string[] args)
        {
            string solutionFolderPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString()).ToString()).ToString();

            foreach (var file in Directory.GetFiles(solutionFolderPath + EndpointSchemaDirectory))
            {
                string endpoint = file.Replace(solutionFolderPath + EndpointSchemaDirectory, "");
                StreamReader reader = new StreamReader(file);
                string input = reader.ReadToEnd();
                reader.Close();

                Schema schema = JsonSchemaParser.ComposeEndpointSchema(input);

                WriteCSharp(
                    solutionFolderPath + string.Format(OutputDirectoryTemplate, endpoint),
                     endpoint,
                    schema,
                   (_) => Console.WriteLine(_));
            }
        }
        private static void WriteCSharp(string outputPath, string endpointName, Schema schema, Action<string> writeLogDelegate)
        {
            outputPath += "\\";
            string endpointNamespace = string.Format(DefaultNamespaceTemplate, endpointName.Replace(".", "_"));

            string csprojPath = outputPath + string.Format(DefaultNamespaceTemplate, endpointName) + ".csproj";

            SchemaGenerator.WriteCSharp(outputPath, schema, writeLogDelegate, endpointNamespace, csprojPath);
        }
    }
}
