using System.Runtime.Serialization;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// The state of the publishing started with PublishBegin.
    /// </summary>
    [DataContract]
    public partial class CustomizationPublishEnd : CustomizationResult
    {
        /// <summary>
        /// Indicates whether the publishing is finished.
        /// </summary>
        [DataMember(Name = "isCompleted", EmitDefaultValue = false)]
        public bool? IsCompleted { get; set; }

        /// <summary>
        /// Indicates whether the publishing failed.
        /// </summary>
        [DataMember(Name = "isFailed", EmitDefaultValue = false)]
        public bool? IsFailed { get; set; }
    }
}
