using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class AccountByPeriodInquiry : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue BranchID { get; set; }

		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue FinancialYear { get; set; }

		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue Ledger { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<AccountByPeriodRow> Results { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

	}
}