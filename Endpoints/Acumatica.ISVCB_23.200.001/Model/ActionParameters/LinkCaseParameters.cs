using System.Runtime.Serialization;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_23_200_001.Model
{
    [DataContract]
    public class LinkCaseParameters
    {
        [DataMember(Name = "RelatedCase", EmitDefaultValue = false)]
        public StringValue? RelatedCase { get; set; }
    }
}