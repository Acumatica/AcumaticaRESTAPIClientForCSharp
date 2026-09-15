using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class WorkOrderActualDetail : Entity
	{

		[DataMember(Name="ActualCost", EmitDefaultValue=false)]
		public DecimalValue? ActualCost { get; set; }

		[DataMember(Name="ActualQty", EmitDefaultValue=false)]
		public DecimalValue? ActualQty { get; set; }

		[DataMember(Name="BillableQty", EmitDefaultValue=false)]
		public DecimalValue? BillableQty { get; set; }

		[DataMember(Name="BillingCategory", EmitDefaultValue=false)]
		public StringSingleSelectValue? BillingCategory { get; set; }

		[DataMember(Name="BillingStatus", EmitDefaultValue=false)]
		public StringValue? BillingStatus { get; set; }

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		[DataMember(Name="CustomerLocationID", EmitDefaultValue=false)]
		public StringValue? CustomerLocationID { get; set; }

		[DataMember(Name="CustomerRefNbr", EmitDefaultValue=false)]
		public StringValue? CustomerRefNbr { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		[DataMember(Name="ExpenseAcctID", EmitDefaultValue=false)]
		public StringValue? ExpenseAcctID { get; set; }

		[DataMember(Name="ExpenseSubID", EmitDefaultValue=false)]
		public StringValue? ExpenseSubID { get; set; }

		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

		[DataMember(Name="ExtPrice", EmitDefaultValue=false)]
		public DecimalValue? ExtPrice { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="InvoiceLineNbr", EmitDefaultValue=false)]
		public IntValue? InvoiceLineNbr { get; set; }

		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		[DataMember(Name="ItemType", EmitDefaultValue=false)]
		public StringValue? ItemType { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		[DataMember(Name="ManualMarkup", EmitDefaultValue=false)]
		public BooleanValue? ManualMarkup { get; set; }

		[DataMember(Name="ManualPrice", EmitDefaultValue=false)]
		public BooleanValue? ManualPrice { get; set; }

		[DataMember(Name="MarkupPct", EmitDefaultValue=false)]
		public DecimalValue? MarkupPct { get; set; }

		[DataMember(Name="OrigDocType", EmitDefaultValue=false)]
		public StringValue? OrigDocType { get; set; }

		[DataMember(Name="OrigNoteID", EmitDefaultValue=false)]
		public GuidValue? OrigNoteID { get; set; }

		[DataMember(Name="PriceRule", EmitDefaultValue=false)]
		public StringValue? PriceRule { get; set; }

		[DataMember(Name="ProfitMarginPercent", EmitDefaultValue=false)]
		public DecimalValue? ProfitMarginPercent { get; set; }

		[DataMember(Name="SalesAcctID", EmitDefaultValue=false)]
		public StringValue? SalesAcctID { get; set; }

		[DataMember(Name="SalesSubID", EmitDefaultValue=false)]
		public StringValue? SalesSubID { get; set; }

		[DataMember(Name="SiteID", EmitDefaultValue=false)]
		public StringValue? SiteID { get; set; }

		[DataMember(Name="StdCost", EmitDefaultValue=false)]
		public DecimalValue? StdCost { get; set; }

		[DataMember(Name="TaxCategoryID", EmitDefaultValue=false)]
		public StringValue? TaxCategoryID { get; set; }

		[DataMember(Name="TicketNbr", EmitDefaultValue=false)]
		public StringValue? TicketNbr { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

		[DataMember(Name="WorkDate", EmitDefaultValue=false)]
		public DateOnlyValue? WorkDate { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}