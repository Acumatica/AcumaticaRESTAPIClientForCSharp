using System;
using System.IO;

using Newtonsoft.Json;

namespace ModelGeneratorConsole
{
    /// <summary>
    /// Settings for a generator run: which Acumatica site to pull field documentation from, and where
    /// schema/output files live relative to the repo root.
    /// </summary>
    public class GeneratorSettings
    {
        public string AcumaticaUrl { get; set; } = "";
        public string AcumaticaUsername { get; set; } = "";
        public string AcumaticaPassword { get; set; } = "";

        public bool GenerateArraysInsteadOfLists { get; set; } = false;
        public bool GenerateApiSectionForBackwardCompatibility { get; set; } = true;

        public string OutputDirectoryTemplate { get; set; } = @"\Endpoints\Acumatica.{0}";
        public string EndpointSchemaDirectory { get; set; } = @"\EndpointDefinitions\";
        public string EndpointMetadataDirectory { get; set; } = @"\EndpointMetadata\";
        public string DefaultNamespaceTemplate { get; set; } = @"Acumatica.{0}";

        /// <summary>
        /// Loads <c>settings.json</c> (checked in, shareable defaults) from <paramref name="settingsDirectory"/>,
        /// then overlays <c>settings.local.json</c> (gitignored, per-developer site URL and credentials) on top
        /// of it when present. Switching which Acumatica instance to read metadata from is then just an edit to
        /// <c>settings.local.json</c>, never a code change.
        /// </summary>
        public static GeneratorSettings Load(string settingsDirectory)
        {
            var settings = new GeneratorSettings();

            string baseFile = Path.Combine(settingsDirectory, "settings.json");
            if (File.Exists(baseFile))
            {
                JsonConvert.PopulateObject(File.ReadAllText(baseFile), settings);
            }

            string localFile = Path.Combine(settingsDirectory, "settings.local.json");
            if (File.Exists(localFile))
            {
                JsonConvert.PopulateObject(File.ReadAllText(localFile), settings);
            }

            if (string.IsNullOrEmpty(settings.AcumaticaUrl))
            {
                throw new InvalidOperationException(
                    $"AcumaticaUrl is not set. Copy '{Path.Combine(settingsDirectory, "settings.local.json.example")}' " +
                    $"to 'settings.local.json' next to it and fill in your site's URL and credentials.");
            }

            return settings;
        }
    }
}
