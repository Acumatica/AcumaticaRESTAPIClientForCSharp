namespace Acumatica.RESTClient.RootApi.Model
{
	/// <summary>
	/// Version
	/// </summary>
    public partial class Version
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Version" /> class.
        /// </summary>
        /// <param name="acumaticaBuildVersion">acumaticaBuildVersion.</param>
        /// <param name="oemBuildVersion">oemBuildVersion.</param>
        /// <param name="databaseVersion">databaseVersion.</param>
        public Version(string? acumaticaBuildVersion = default, string? oemBuildVersion = default, string? databaseVersion = default)
        {
            AcumaticaBuildVersion = acumaticaBuildVersion;
            OemBuildVersion = oemBuildVersion;
            DatabaseVersion = databaseVersion;
        }

        /// <summary>
        /// Gets or Sets AcumaticaBuildVersion
        /// </summary>
        public string? AcumaticaBuildVersion { get; set; }

        /// <summary>
        /// Gets or Sets OemBuildVersion
        /// </summary>
        public string? OemBuildVersion { get; set; }

        /// <summary>
        /// Gets or Sets DatabaseVersion
        /// </summary>
        public string? DatabaseVersion { get; set; }
    }
}
