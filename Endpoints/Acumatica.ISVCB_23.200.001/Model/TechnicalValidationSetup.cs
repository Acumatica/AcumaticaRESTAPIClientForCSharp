using System.Runtime.Serialization;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_23_200_001.Model
{

    [DataContract]
    public class TechnicalValidationSetup : Entity, ITopLevelEntity
    {
        [DataMember(Name = "ErrorCaseClassID", EmitDefaultValue = false)]
        public StringValue? ErrorCaseClassID { get; set; }

        [DataMember(Name = "GracePeriod", EmitDefaultValue = false)]
        public IntValue? GracePeriod { get; set; }

        [DataMember(Name = "ISVCaseClassID", EmitDefaultValue = false)]
        public StringValue? ISVCaseClassID { get; set; }

        [DataMember(Name = "ISVSupportedVersion", EmitDefaultValue = false)]
        public StringValue? ISVSupportedVersion { get; set; }

        [DataMember(Name = "ServiceURL", EmitDefaultValue = false)]
        public StringValue? ServiceURL { get; set; }

        [DataMember(Name = "VARCaseClassID", EmitDefaultValue = false)]
        public StringValue? VARCaseClassID { get; set; }

        [DataMember(Name = "VARSupportedVersion", EmitDefaultValue = false)]
        public StringValue? VARSupportedVersion { get; set; }

        public virtual string GetEndpointPath()
        {
            return "entity/ISVCB/23.200.001";
        }
    }
}