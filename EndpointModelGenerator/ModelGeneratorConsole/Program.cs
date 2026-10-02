using System;
using System.IO;

using EndpointModelGenerator;

using EndpointSchemaGenerator;

namespace ModelGeneratorConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? solutionFolderPath = GetParentDirectory(Directory.GetCurrentDirectory(), 5)?.ToString();
            string settingsDirectory = Path.Combine(solutionFolderPath!, "EndpointModelGenerator", "ModelGeneratorConsole");
            GeneratorSettings settings = GeneratorSettings.Load(settingsDirectory);

            foreach (var fileName in Directory.GetFiles(solutionFolderPath + settings.EndpointSchemaDirectory))
            {
                string endpoint = fileName.Replace(solutionFolderPath + settings.EndpointSchemaDirectory, "");
                StreamReader reader = new StreamReader(fileName);
                string endpointDefinition = reader.ReadToEnd();
                reader.Close();
                JsonSchemaParser.GenerateArraysInstedOfLists = settings.GenerateArraysInsteadOfLists;
                Schema endpointSchema = JsonSchemaParser.ComposeEndpointSchema(endpointDefinition);

                string endpointMetadataPath = solutionFolderPath + settings.EndpointMetadataDirectory + endpoint;
                if (File.Exists(endpointMetadataPath))
                {
                    reader = new StreamReader(endpointMetadataPath);
                    string endpointMetadata = reader.ReadToEnd();
                    reader.Close();
                    reader = new StreamReader(solutionFolderPath + settings.EndpointMetadataDirectory + "ScreensMetadata.csv");
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
                    SchemaEnricher.AddFieldDescriptions(endpointSchema, settings.AcumaticaUrl, settings.AcumaticaUsername, settings.AcumaticaPassword);
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

                string pathToWrite = solutionFolderPath + string.Format(settings.OutputDirectoryTemplate, endpoint);
                Console.WriteLine($"Writing in {pathToWrite}");
                SchemaGenerator.WriteCSharp(
                   pathToWrite,
                     endpoint,
                    endpointSchema,
                       (_) => Console.WriteLine(_),
                      settings.DefaultNamespaceTemplate,
                      settings.GenerateApiSectionForBackwardCompatibility);
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
