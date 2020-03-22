using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class InterBranchAccountMappingTransactionInDestinationBranchDetail : Entity
	{

		[DataMember(Name="AccountFrom", EmitDefaultValue=false)]
		public StringValue AccountFrom { get; set; }

		[DataMember(Name="AccountTo", EmitDefaultValue=false)]
		public StringValue AccountTo { get; set; }

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public IntValue BranchID { get; set; }

		[DataMember(Name="DestinationBranch", EmitDefaultValue=false)]
		public StringValue DestinationBranch { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="OffsetAccount", EmitDefaultValue=false)]
		public StringValue OffsetAccount { get; set; }

		[DataMember(Name="OffsetSubaccount", EmitDefaultValue=false)]
		public StringValue OffsetSubaccount { get; set; }

	}
}