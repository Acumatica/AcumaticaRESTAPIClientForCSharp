using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class TimeAndMaterial : Entity_v4
	{

		[DataMember(Name="AmountToInvoice", EmitDefaultValue=false)]
		public DecimalValue AmountToInvoice { get; set; }

		[DataMember(Name="BilledAmount", EmitDefaultValue=false)]
		public DecimalValue BilledAmount { get; set; }

		[DataMember(Name="BilledQty", EmitDefaultValue=false)]
		public DecimalValue BilledQty { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="DeferralCode", EmitDefaultValue=false)]
		public StringValue DeferralCode { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue EmployeeID { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="MaxAvailableAmount", EmitDefaultValue=false)]
		public DecimalValue MaxAvailableAmount { get; set; }

		[DataMember(Name="MaxLimitAmount", EmitDefaultValue=false)]
		public DecimalValue MaxLimitAmount { get; set; }

		[DataMember(Name="OverLimitAmount", EmitDefaultValue=false)]
		public DecimalValue OverLimitAmount { get; set; }

		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue ProjectTaskID { get; set; }

		[DataMember(Name="QtyToInvoice", EmitDefaultValue=false)]
		public DecimalValue QtyToInvoice { get; set; }

		[DataMember(Name="Retainage", EmitDefaultValue=false)]
		public DecimalValue Retainage { get; set; }

		[DataMember(Name="RetainageAmount", EmitDefaultValue=false)]
		public DecimalValue RetainageAmount { get; set; }

		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue SalesAccount { get; set; }

		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue SalesSubaccount { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue UnitPrice { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue Vendor { get; set; }

	}
}