using System;
using System.Collections.Generic;
using System.Linq;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// The result of a Customization API call. Calls that do not return anything else
    /// (import, delete, publish begin, unpublish) return only the log of the operation.
    /// </summary>
    public partial class CustomizationResult
    {
        /// <summary>
        /// The log of the operation.
        /// </summary>
        public List<CustomizationPublishLog>? Log { get; set; }

        /// <summary>
        /// <c>true</c> if the log contains an error record.
        /// </summary>
        /// <remarks>
        /// The server answers some failures, such as a project that is not found, with a successful
        /// HTTP status and an error record in the log, so the result should be checked.
        /// </remarks>
        public bool HasErrors
        {
            get { return Log != null && Log.Any(_ => string.Equals(_.LogType, "error", StringComparison.OrdinalIgnoreCase)); }
        }
    }
}
