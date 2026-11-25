using System;
using System.Collections.Generic;
using System.Linq;

using Acumatica.RESTClient.CustomizationApi.Model;

namespace Acumatica.RESTClient.CustomizationApi
{
    /// <summary>
    /// Thrown when publishing of customization projects fails on the server.
    /// </summary>
    public class CustomizationPublishException : Exception
    {
        /// <summary>
        /// Creates the exception from the publishing log.
        /// </summary>
        /// <param name="log">The log records returned by the server.</param>
        public CustomizationPublishException(IEnumerable<CustomizationPublishLog>? log)
            : base(BuildMessage(log))
        {
            Log = log?.ToList() ?? new List<CustomizationPublishLog>();
        }

        /// <summary>
        /// The log records returned by the server.
        /// </summary>
        public IReadOnlyList<CustomizationPublishLog> Log { get; }

        private static string BuildMessage(IEnumerable<CustomizationPublishLog>? log)
        {
            string message = string.Join(Environment.NewLine, log?.Select(_ => _.Message).Where(_ => !string.IsNullOrEmpty(_)) ?? Enumerable.Empty<string?>());
            return message.Length > 0 ? message : "Publishing of the customization failed.";
        }
    }
}
