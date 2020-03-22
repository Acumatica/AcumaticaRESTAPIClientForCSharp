using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class AccountSummaryInquiry : Entity
	{

		[DataMember(Name="AccountClass", EmitDefaultValue=false)]
		public StringValue AccountClass { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue Ledger { get; set; }

		[DataMember(Name="Period", EmitDefaultValue=false)]
		public StringValue Period { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<AccountSummaryRow> Results { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

	}
}