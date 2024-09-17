using EndpointSchemaGenerator;
using System;
using System.IO;

namespace ModelGeneratorConsole
{
    internal class Program
    {

        #region Settings
        const bool GenerateArraysInstedOfLists = false;
        const bool GenerateAPISectionForBackWardCompatibility = true;

        const string OutputDirectoryTemplate = @"\Acumatica.{0}";
        const string EndpointSchemaDirectory = @"\EndpointDefinitions\";
        const string DefaultNamespaceTemplate = @"Acumatica.{0}";
        #endregion

        static void Main(string[] args)
        {
            string? solutionFolderPath = GetParentDirectory(Directory.GetCurrentDirectory(), 5)?.ToString();

            foreach (var file in Directory.GetFiles(solutionFolderPath + EndpointSchemaDirectory))
            {
                string endpoint = file.Replace(solutionFolderPath + EndpointSchemaDirectory, "");
                StreamReader reader = new StreamReader(file);
                string input = reader.ReadToEnd();
                reader.Close();
                JsonSchemaParser.GenerateArraysInstedOfLists = GenerateArraysInstedOfLists;
                Schema schema = JsonSchemaParser.ComposeEndpointSchema(input);

                WriteCSharp(
                    solutionFolderPath + string.Format(OutputDirectoryTemplate, endpoint),
                     endpoint,
                    schema,
                   (_) => Console.WriteLine(_), 
                   GenerateAPISectionForBackWardCompatibility);
            }

        }

        private static DirectoryInfo? GetParentDirectory(string currentDirectory, int levels = 1)
        {
            if(levels<1)
                throw new ArgumentOutOfRangeException(nameof(levels), "Number of levels must be grater than 0");
            var parentDirectory = Directory.GetParent(currentDirectory);
            if (parentDirectory == null)
            {
                return null;
            }
            else
            {
                for (int i = 1; i < levels; i++)
                {
                    parentDirectory = parentDirectory!.Parent;
                }
            }
            return parentDirectory;
        }

        private static void WriteCSharp(string outputPath, string endpointName, Schema schema, Action<string> writeLogDelegate, bool generateApis = true)
        {
            outputPath += "\\";
            string endpointNamespace = string.Format(DefaultNamespaceTemplate, endpointName.Replace(".", "_"));

            string csprojPath = outputPath + string.Format(DefaultNamespaceTemplate, endpointName) + ".csproj";

            SchemaGenerator.WriteCSharp(outputPath, schema, writeLogDelegate, endpointNamespace, csprojPath, generateApis: generateApis);
        }
    }
}
