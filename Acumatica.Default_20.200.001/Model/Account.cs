using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Account : Entity_v4
	{

		[DataMember(Name="AccountCD", EmitDefaultValue=false)]
		public StringValue AccountCD { get; set; }

		[DataMember(Name="AccountClass", EmitDefaultValue=false)]
		public StringValue AccountClass { get; set; }

		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue AccountGroup { get; set; }

		[DataMember(Name="AccountID", EmitDefaultValue=false)]
		public IntValue AccountID { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public BooleanValue CashAccount { get; set; }

		[DataMember(Name="ChartOfAccountsOrder", EmitDefaultValue=false)]
		public IntValue ChartOfAccountsOrder { get; set; }

		[DataMember(Name="ConsolidationAccount", EmitDefaultValue=false)]
		public StringValue ConsolidationAccount { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="PostOption", EmitDefaultValue=false)]
		public StringValue PostOption { get; set; }

		[DataMember(Name="RequireUnits", EmitDefaultValue=false)]
		public BooleanValue RequireUnits { get; set; }

		[DataMember(Name="RevaluationRateType", EmitDefaultValue=false)]
		public StringValue RevaluationRateType { get; set; }

		[DataMember(Name="Secured", EmitDefaultValue=false)]
		public BooleanValue Secured { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="UseDefaultSubaccount", EmitDefaultValue=false)]
		public BooleanValue UseDefaultSubaccount { get; set; }

	}
}