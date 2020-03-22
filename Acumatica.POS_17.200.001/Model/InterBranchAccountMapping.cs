using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class InterBranchAccountMapping : Entity
	{

		[DataMember(Name="OriginatingBranch", EmitDefaultValue=false)]
		public StringValue OriginatingBranch { get; set; }

		[DataMember(Name="PostingLedger", EmitDefaultValue=false)]
		public StringValue PostingLedger { get; set; }

		[DataMember(Name="TransactionsInDestinationBranch", EmitDefaultValue=false)]
		public List<InterBranchAccountMappingTransactionInDestinationBranchDetail> TransactionsInDestinationBranch { get; set; }

		[DataMember(Name="TransactionsInSourceBranch", EmitDefaultValue=false)]
		public List<InterBranchAccountMappingTransactionInSourceBranchDetail> TransactionsInSourceBranch { get; set; }

	}
}