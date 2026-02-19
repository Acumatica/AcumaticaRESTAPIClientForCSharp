using System;
using System.IO;
using Microsoft.Extensions.Configuration;

using EndpointModelGenerator;
using EndpointSchemaGenerator;

namespace ModelGeneratorConsole
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var settings = LoadSettings();

			string? solutionFolderPath = GetParentDirectory(
				Directory.GetCurrentDirectory(),
				settings.SolutionFolderLevelsUp
			)?.ToString();

			if (string.IsNullOrWhiteSpace(solutionFolderPath))
			{
				Console.WriteLine("Could not resolve solution folder path.");
				return;
			}

			var schemaDir = Path.Combine(solutionFolderPath, TrimLeadingSlashes(settings.EndpointSchemaDirectory));
			var metadataDir = Path.Combine(solutionFolderPath, TrimLeadingSlashes(settings.EndpointMetadataDirectory));

			foreach (var fileName in Directory.GetFiles(schemaDir))
			{
				string endpoint = fileName.Replace(schemaDir, "");
				using (var reader = new StreamReader(fileName))
				{
					string endpointDefinition = reader.ReadToEnd();

					Schema endpointSchema = JsonSchemaParser.ComposeEndpointSchema(endpointDefinition, settings);

					string endpointMetadataPath = Path.Combine(metadataDir, endpoint);
					if (File.Exists(endpointMetadataPath))
					{
						string endpointMetadata;
						using (var mdReader = new StreamReader(endpointMetadataPath))
							endpointMetadata = mdReader.ReadToEnd();

						var screensMetadataPath = Path.Combine(metadataDir, "ScreensMetadata.csv");
						string screensMetadata = File.Exists(screensMetadataPath)
							? File.ReadAllText(screensMetadataPath)
							: "";

						if (!string.IsNullOrEmpty(endpointMetadata))
						{
							SchemaEnricher.EnrichSchema(endpointSchema, endpointMetadata, screensMetadata);
						}
					}

					try
					{
						Console.WriteLine("Getting field descriptions for " + endpoint);
						SchemaEnricher.AddFieldDescriptions(
							endpointSchema,
							settings.MetadataSource
						);
					}
					catch (Exception e)
					{
						Console.WriteLine("Failed to get field descriptions: " + e.Message);
					}

					string pathToWrite = Path.Combine(
						solutionFolderPath,
						string.Format(settings.OutputDirectoryTemplate, endpoint).TrimStart('\\', '/')
					);

					Console.WriteLine($"Writing in {pathToWrite}");

					SchemaGenerator.WriteCSharp(
						pathToWrite,
						endpoint,
						endpointSchema,
						(_) => Console.WriteLine(_),
						settings
					);
				}
			}
		}

		private static GeneratorSettings LoadSettings()
		{
			var config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
				.Build();

			var settings = config.GetSection("GeneratorSettings").Get<GeneratorSettings>();
			if (settings == null)
				throw new InvalidOperationException("Missing GeneratorSettings in appsettings.json.");

			// Minimal validation (fail fast)
			if (string.IsNullOrWhiteSpace(settings.EndpointSchemaDirectory))
				throw new InvalidOperationException("GeneratorSettings:EndpointSchemaDirectory is required.");
			if (string.IsNullOrWhiteSpace(settings.OutputDirectoryTemplate))
				throw new InvalidOperationException("GeneratorSettings:OutputDirectoryTemplate is required.");
			if (string.IsNullOrWhiteSpace(settings.DefaultNamespaceTemplate))
				throw new InvalidOperationException("GeneratorSettings:DefaultNamespaceTemplate is required.");

			return settings;
		}

		private static string TrimLeadingSlashes(string value)
			=> value.TrimStart('\\', '/');

		private static DirectoryInfo? GetParentDirectory(string currentDirectory, int levels = 1)
		{
			if (levels < 1)
				throw new ArgumentOutOfRangeException(nameof(levels), "Number of levels must be grater than 0");

			var parentDirectory = Directory.GetParent(currentDirectory);
			if (parentDirectory == null)
				return null;

			for (int i = 1; i < levels; i++)
			{
				parentDirectory = parentDirectory.Parent;
				if (parentDirectory == null)
					return null;
			}

			return parentDirectory;
		}
	}
}
