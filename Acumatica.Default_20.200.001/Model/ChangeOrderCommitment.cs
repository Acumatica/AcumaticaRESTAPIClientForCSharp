using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ChangeOrderCommitment : Entity_v4
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="AmountinBaseCurrency", EmitDefaultValue=false)]
		public DecimalValue AmountinBaseCurrency { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LineAmount", EmitDefaultValue=false)]
		public DecimalValue LineAmount { get; set; }

		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue LineDescription { get; set; }

		[DataMember(Name="OpenAmount", EmitDefaultValue=false)]
		public DecimalValue OpenAmount { get; set; }

		[DataMember(Name="OpenQty", EmitDefaultValue=false)]
		public DecimalValue OpenQty { get; set; }

		[DataMember(Name="OrderDate", EmitDefaultValue=false)]
		public DateTimeValue OrderDate { get; set; }

		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue OrderQty { get; set; }

		[DataMember(Name="POLineNbr", EmitDefaultValue=false)]
		public IntValue POLineNbr { get; set; }

		[DataMember(Name="PONbr", EmitDefaultValue=false)]
		public StringValue PONbr { get; set; }

		[DataMember(Name="PotentiallyRevisedAmount", EmitDefaultValue=false)]
		public DecimalValue PotentiallyRevisedAmount { get; set; }

		[DataMember(Name="PotentiallyRevisedQty", EmitDefaultValue=false)]
		public DecimalValue PotentiallyRevisedQty { get; set; }

		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue ProjectTaskID { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue Vendor { get; set; }

	}
}