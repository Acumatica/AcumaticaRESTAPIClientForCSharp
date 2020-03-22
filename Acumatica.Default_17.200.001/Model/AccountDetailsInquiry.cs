using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class AccountDetailsInquiry : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="BeginingBalance", EmitDefaultValue=false)]
		public DecimalValue BeginingBalance { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="EndingBalance", EmitDefaultValue=false)]
		public DecimalValue EndingBalance { get; set; }

		[DataMember(Name="FromDate", EmitDefaultValue=false)]
		public DateTimeValue FromDate { get; set; }

		[DataMember(Name="FromPeriod", EmitDefaultValue=false)]
		public StringValue FromPeriod { get; set; }

		[DataMember(Name="IncludeReclassified", EmitDefaultValue=false)]
		public BooleanValue IncludeReclassified { get; set; }

		[DataMember(Name="IncludeUnposted", EmitDefaultValue=false)]
		public BooleanValue IncludeUnposted { get; set; }

		[DataMember(Name="IncludeUnreleased", EmitDefaultValue=false)]
		public BooleanValue IncludeUnreleased { get; set; }

		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue Ledger { get; set; }

		[DataMember(Name="PeriodEndDate", EmitDefaultValue=false)]
		public DateTimeValue PeriodEndDate { get; set; }

		[DataMember(Name="PeriodStartDate", EmitDefaultValue=false)]
		public DateTimeValue PeriodStartDate { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<AccountDetailsRow> Results { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

		[DataMember(Name="ToDate", EmitDefaultValue=false)]
		public DateTimeValue ToDate { get; set; }

		[DataMember(Name="ToPeriod", EmitDefaultValue=false)]
		public StringValue ToPeriod { get; set; }

		[DataMember(Name="Turnover", EmitDefaultValue=false)]
		public DecimalValue Turnover { get; set; }

	}
}