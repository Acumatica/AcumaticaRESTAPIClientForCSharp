using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class LedgerBranches : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue BranchID { get; set; }

		[DataMember(Name="BranchName", EmitDefaultValue=false)]
		public StringValue BranchName { get; set; }

		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue CompanyName { get; set; }

	}
}