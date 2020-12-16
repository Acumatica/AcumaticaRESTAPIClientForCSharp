using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class BudgetDetail : Entity_v4
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue CreatedBy { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DistributedAmount", EmitDefaultValue=false)]
		public DecimalValue DistributedAmount { get; set; }

		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue FinancialYear { get; set; }

		[DataMember(Name="GroupID", EmitDefaultValue=false)]
		public GuidValue GroupID { get; set; }

		[DataMember(Name="LastModifiedBy", EmitDefaultValue=false)]
		public StringValue LastModifiedBy { get; set; }

		[DataMember(Name="LedgerID", EmitDefaultValue=false)]
		public StringValue LedgerID { get; set; }

		[DataMember(Name="Node", EmitDefaultValue=false)]
		public BooleanValue Node { get; set; }

		[DataMember(Name="Period01", EmitDefaultValue=false)]
		public DecimalValue Period01 { get; set; }

		[DataMember(Name="Period02", EmitDefaultValue=false)]
		public DecimalValue Period02 { get; set; }

		[DataMember(Name="Period03", EmitDefaultValue=false)]
		public DecimalValue Period03 { get; set; }

		[DataMember(Name="Period04", EmitDefaultValue=false)]
		public DecimalValue Period04 { get; set; }

		[DataMember(Name="Period05", EmitDefaultValue=false)]
		public DecimalValue Period05 { get; set; }

		[DataMember(Name="Period06", EmitDefaultValue=false)]
		public DecimalValue Period06 { get; set; }

		[DataMember(Name="Period07", EmitDefaultValue=false)]
		public DecimalValue Period07 { get; set; }

		[DataMember(Name="Period08", EmitDefaultValue=false)]
		public DecimalValue Period08 { get; set; }

		[DataMember(Name="Period09", EmitDefaultValue=false)]
		public DecimalValue Period09 { get; set; }

		[DataMember(Name="Period10", EmitDefaultValue=false)]
		public DecimalValue Period10 { get; set; }

		[DataMember(Name="Period11", EmitDefaultValue=false)]
		public DecimalValue Period11 { get; set; }

		[DataMember(Name="Period12", EmitDefaultValue=false)]
		public DecimalValue Period12 { get; set; }

		[DataMember(Name="Period13", EmitDefaultValue=false)]
		public DecimalValue Period13 { get; set; }

		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue Released { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

	}
}