using System.IO;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.AuthApi.Model
{
	[DataContract]
    public partial class Credentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Credentials" /> class.
        /// </summary>
        /// <param name="name">Username (required).</param>
        /// <param name="password">User password (required).</param>
        /// <param name="tenant">Defines the tenant to log in.</param>
        /// <param name="branch">Defines the branch to log in.</param>
        /// <param name="locale">Defines the locale to use for localizable data.</param>
        public Credentials(string name, string password, string? company = null, string? tenant = null, string? branch = null, string? locale = null)
        {
            // to ensure "name" is required (not null)
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidDataException($"{nameof(name)} is a required property for {nameof(Credentials)} and cannot be null");
            }
            else
            {
                Name = name;
            }
            // to ensure "password" is required (not null)
            if (string.IsNullOrEmpty(password))
            {
                throw new InvalidDataException($"{nameof(password)} is a required property for {nameof(Credentials)} and cannot be null");
            }
            else
            {
                Password = password;
            }

            if (!string.IsNullOrEmpty(company) && !string.IsNullOrEmpty(tenant))
            {
                throw new InvalidDataException($"Both {nameof(company)} and {nameof(tenant)} cannot be defined in the same request. Please use {nameof(tenant)}.");
            }
            Tenant = string.IsNullOrEmpty(tenant) ? company : tenant;
            Branch = branch;
            Locale = locale;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Tenant
        /// </summary>
        [DataMember(Name = "tenant", EmitDefaultValue = false)]
        public string? Tenant { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name = "branch", EmitDefaultValue = false)]
        public string? Branch { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string? Locale { get; set; }

    }

}
