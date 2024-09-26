using System;
using System.IO;

using EndpointModelGenerator;

using EndpointSchemaGenerator;

namespace ModelGeneratorConsole
{
    internal class Program
    {

        #region Settings
        const bool GenerateArraysInstedOfLists = false;
        const bool GenerateAPISectionForBackWardCompatibility = true;

        const string OutputDirectoryTemplate = @"\Acumatica.{0}";
        const string EndpointSchemaDirectory = @"\EndpointDefinitions\";
        const string EndpointMetadataDirectory = @"\EndpointMetadata\";
        const string DefaultNamespaceTemplate = @"Acumatica.{0}";
        #endregion

        static void Main(string[] args)
        {
            string? solutionFolderPath = GetParentDirectory(Directory.GetCurrentDirectory(), 5)?.ToString();

            foreach (var fileName in Directory.GetFiles(solutionFolderPath + EndpointSchemaDirectory))
            {
                string endpoint = fileName.Replace(solutionFolderPath + EndpointSchemaDirectory, "");
                StreamReader reader = new StreamReader(fileName);
                string endpointDefinition = reader.ReadToEnd();
                reader.Close();
                JsonSchemaParser.GenerateArraysInstedOfLists = GenerateArraysInstedOfLists;
                Schema endpointSchema = JsonSchemaParser.ComposeEndpointSchema(endpointDefinition);

                string endpointMetadataPath = solutionFolderPath + EndpointMetadataDirectory + endpoint;
                if (File.Exists(endpointMetadataPath))
                {
                    reader = new StreamReader(endpointMetadataPath);
                    string endpointMetadata = reader.ReadToEnd();
                    reader.Close();
                    reader = new StreamReader(solutionFolderPath + EndpointMetadataDirectory + "ScreensMetadata.csv");
                    string screensMetadata = reader.ReadToEnd();
                    reader.Close();
                    if (!string.IsNullOrEmpty(endpointMetadata))
                    {
                        SchemaEnricher.EnrichSchema(endpointSchema, endpointMetadata, screensMetadata);
                    }
                }
                try
                {
                    Console.WriteLine("Getting field descriptions for " + endpoint);
                    SchemaEnricher.AddFieldDescriptions(endpointSchema, "https://localhost/24r200", "admin", "123");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to get field descriptions: " + e.Message);
                }
                //write toplevelntites to a file
                //StreamWriter writer = new StreamWriter(solutionFolderPath + @"\TopLevelEntities.csv", true);
                //foreach (var item in endpointSchema.TopLevelEntities)
                //{
                //    writer.WriteLine($"{item.Key},{item.Value}");
                //}
                //writer.Close();

                SchemaGenerator.WriteCSharp(
                    solutionFolderPath + string.Format(OutputDirectoryTemplate, endpoint),
                     endpoint,
                    endpointSchema,
                       (_) => Console.WriteLine(_),
                      DefaultNamespaceTemplate,
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
    }
}
