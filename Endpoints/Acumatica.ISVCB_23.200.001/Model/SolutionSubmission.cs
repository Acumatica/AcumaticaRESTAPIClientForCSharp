using System.Collections.Generic;
using System.Runtime.Serialization;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_23_200_001.Model
{
    [DataContract]
    public class SolutionSubmission : Entity, ITopLevelEntity
    {
        [DataMember(Name = "AcumaticaBuild", EmitDefaultValue = false)]
        public StringValue? AcumaticaBuild { get; set; }

        [DataMember(Name = "AcumaticaVersion", EmitDefaultValue = false)]
        public StringValue? AcumaticaVersion { get; set; }

        [DataMember(Name = "ISVSolutionCode", EmitDefaultValue = false)]
        public StringValue? ISVSolutionCode { get; set; }

        [DataMember(Name = "Contact", EmitDefaultValue = false)]
        public StringValue? Contact { get; set; }

        [DataMember(Name = "BusinessAccount", EmitDefaultValue = false)]
        public StringValue? BusinessAccount { get; set; }

        [DataMember(Name = "RelatedCase", EmitDefaultValue = false)]
        public StringValue? RelatedCase { get; set; }

        [DataMember(Name = "SolutionVersion", EmitDefaultValue = false)]
        public StringValue? SolutionVersion { get; set; }

        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public StringValue? Status { get; set; }

        [DataMember(Name = "ValidationDateTime", EmitDefaultValue = false)]
        public DateTimeValue? ValidationDateTime { get; set; }

        [DataMember(Name = "CreatedDateTime", EmitDefaultValue = false)]
        public DateTimeValue? CreatedDateTime { get; set; }

        [DataMember(Name = "LastModifiedDateTime", EmitDefaultValue = false)]
        public DateTimeValue? LastModifiedDateTime { get; set; }

        [DataMember(Name = "CreatedBy", EmitDefaultValue = false)]
        public StringValue? CreatedBy { get; set; }

        [DataMember(Name = "LastModifiedBy", EmitDefaultValue = false)]
        public StringValue? LastModifiedBy { get; set; }

        [DataMember(Name = "ContactEmail", EmitDefaultValue = false)]
        public StringValue? ContactEmail { get; set; }

        [DataMember(Name = "SolutionFiles", EmitDefaultValue = false)]
        public List<SolutionFile>? SolutionFiles { get; set; }

        public virtual string GetEndpointPath()
        {
            return "entity/ISVCB/23.200.001";
        }
    }
}