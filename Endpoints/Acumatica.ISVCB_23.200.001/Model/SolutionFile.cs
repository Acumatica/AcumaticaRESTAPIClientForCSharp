using System.Runtime.Serialization;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_23_200_001.Model
{
    [DataContract]
    public class SolutionFile : Entity
    {
        [DataMember(Name = "Comment", EmitDefaultValue = false)]
        public StringValue? Comment { get; set; }

        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public StringValue? Name { get; set; }

        [DataMember(Name = "FileType", EmitDefaultValue = false)]
        public StringValue? FileType { get; set; }

        [DataMember(Name = "Initials", EmitDefaultValue = false)]
        public StringValue? Initials { get; set; }

        [DataMember(Name = "Main", EmitDefaultValue = false)]
        public BooleanValue? Main { get; set; }

        [DataMember(Name = "LineNbr", EmitDefaultValue = false)]
        public IntValue? LineNbr { get; set; }
    }
}