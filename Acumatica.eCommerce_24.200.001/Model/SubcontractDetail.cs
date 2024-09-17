using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class SubcontractDetail : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		[DataMember(Name="AlternateID", EmitDefaultValue=false)]
		public StringValue? AlternateID { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		[DataMember(Name="Canceled", EmitDefaultValue=false)]
		public BooleanValue? Canceled { get; set; }

		[DataMember(Name="Closed", EmitDefaultValue=false)]
		public BooleanValue? Closed { get; set; }

		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public BooleanValue? Completed { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue? DiscountCode { get; set; }

		[DataMember(Name="DiscountPct", EmitDefaultValue=false)]
		public DecimalValue? DiscountPct { get; set; }

		[DataMember(Name="DiscountSequence", EmitDefaultValue=false)]
		public StringValue? DiscountSequence { get; set; }

		[DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
		public DecimalValue? ExtendedCost { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue? LineDescription { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="ManualCost", EmitDefaultValue=false)]
		public BooleanValue? ManualCost { get; set; }

		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue? ManualDiscount { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue? OrderQty { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		[DataMember(Name="PrepaidAmount", EmitDefaultValue=false)]
		public DecimalValue? PrepaidAmount { get; set; }

		[DataMember(Name="PrepaidQty", EmitDefaultValue=false)]
		public DecimalValue? PrepaidQty { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="Task", EmitDefaultValue=false)]
		public StringValue? Task { get; set; }

		[DataMember(Name="Requested", EmitDefaultValue=false)]
		public DateTimeValue? Requested { get; set; }

		[DataMember(Name="RetainageAmount", EmitDefaultValue=false)]
		public DecimalValue? RetainageAmount { get; set; }

		[DataMember(Name="RetainagePct", EmitDefaultValue=false)]
		public DecimalValue? RetainagePct { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}