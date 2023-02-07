using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;


namespace Acumatica.RESTClient.Auth.Model
{
    /// <summary>
    /// Credentials
    /// </summary>
    [DataContract]
    public partial class Credentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Credentials" /> class.
        /// </summary>
        [JsonConstructor]
        protected Credentials() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Credentials" /> class.
        /// </summary>
        /// <param name="name">Username (required).</param>
        /// <param name="password">User password (required).</param>
        /// <param name="company">[Obsolete] Company parameter defines tenant to log in. Please use <paramref name="tenant"/> instead.</param>
        /// <param name="tenant">Defines the tenant to log in.</param>
        /// <param name="branch">Defines the branch to log in.</param>
        /// <param name="locale">Defines the locale to use for localizable data.</param>
        public Credentials(string name = default, string password = default, string company = default, string tenant = default, string branch = default, string locale = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Credentials and cannot be null");
            }
            else
            {
                Name = name;
            }
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for Credentials and cannot be null");
            }
            else
            {
                Password = password;
            }

            if (!string.IsNullOrEmpty(company) && !string.IsNullOrEmpty(tenant))
            {
                throw new InvalidDataException($"Both {nameof(company)} and {nameof(tenant)} cannot be defined in the same request. Please use {nameof(tenant)}.");
            }

            Company = null;
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
        /// Gets or Sets Company
        /// </summary>
        [Obsolete("Please use teanant instead")]
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or Sets Tenant
        /// </summary>
        [DataMember(Name = "tenant", EmitDefaultValue = false)]
        public string Tenant { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name = "branch", EmitDefaultValue = false)]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

    }
}
