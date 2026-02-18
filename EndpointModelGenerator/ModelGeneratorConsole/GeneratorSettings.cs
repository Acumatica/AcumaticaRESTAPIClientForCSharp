namespace ModelGeneratorConsole
{
	public sealed class GeneratorSettings
	{
		public bool GenerateArraysInsteadOfLists { get; set; }
		public bool GenerateAPISectionForBackWardCompatibility { get; set; }

		public string OutputDirectoryTemplate { get; set; } = "";
		public string EndpointSchemaDirectory { get; set; } = "";
		public string EndpointMetadataDirectory { get; set; } = "";
		public string DefaultNamespaceTemplate { get; set; } = "";

		public MetadataSource MetadataSource { get; set; } = new();

		public int SolutionFolderLevelsUp { get; set; } = 5;
	}

	public sealed class MetadataSource
	{
		public string Url { get; set; } = "";
		public string Username { get; set; } = "";
		public string Password { get; set; } = "";
	}
}
