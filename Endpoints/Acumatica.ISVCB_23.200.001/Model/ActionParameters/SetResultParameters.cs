using System.Runtime.Serialization;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_23_200_001.Model
{
    [DataContract]
    public class SetResultParameters
    {
        [DataMember(Name = "Result", EmitDefaultValue = false)]
        public StringValue? Result { get; set; }
    }
}