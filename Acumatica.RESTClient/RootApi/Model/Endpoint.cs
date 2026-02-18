namespace Acumatica.RESTClient.RootApi.Model
{
	/// <summary>
	/// Endpoint
	/// </summary>
    public partial class Endpoint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="version">version.</param>
        /// <param name="href">href.</param>
        public Endpoint(string? name = default, string? version = default, string? href = default)
        {
            Name = name;
            Version = version;
            Href = href;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        public string? Version { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        public string? Href { get; set; }
    }
}
