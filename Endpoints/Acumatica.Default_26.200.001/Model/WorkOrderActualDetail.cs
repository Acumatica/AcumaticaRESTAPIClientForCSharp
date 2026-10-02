using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class WorkOrderActualDetail : Entity
	{

		#region Fields
		public DecimalValue? ActualCost { get; set; }

		public DecimalValue? ActualQty { get; set; }

		public DecimalValue? BillableQty { get; set; }

		public StringSingleSelectValue? BillingCategory { get; set; }

		public StringValue? BillingStatus { get; set; }

		public StringValue? BranchID { get; set; }

		public StringValue? CustomerID { get; set; }

		public StringValue? CustomerLocationID { get; set; }

		public StringValue? CustomerRefNbr { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? EmployeeID { get; set; }

		public StringValue? EmployeeName { get; set; }

		public StringValue? ExpenseAcctID { get; set; }

		public StringValue? ExpenseSubID { get; set; }

		public DecimalValue? ExtCost { get; set; }

		public DecimalValue? ExtPrice { get; set; }

		public StringValue? InventoryID { get; set; }

		public IntValue? InvoiceLineNbr { get; set; }

		public StringValue? InvoiceNbr { get; set; }

		public StringValue? ItemType { get; set; }

		public IntValue? LineNbr { get; set; }

		public StringValue? LocationID { get; set; }

		public BooleanValue? ManualMarkup { get; set; }

		public BooleanValue? ManualPrice { get; set; }

		public DecimalValue? MarkupPct { get; set; }

		public StringValue? OrigDocType { get; set; }

		public GuidValue? OrigNoteID { get; set; }

		public StringValue? PriceRule { get; set; }

		public DecimalValue? ProfitMarginPercent { get; set; }

		public StringValue? SalesAcctID { get; set; }

		public StringValue? SalesSubID { get; set; }

		public StringValue? SiteID { get; set; }

		public DecimalValue? StdCost { get; set; }

		public StringValue? TaxCategoryID { get; set; }

		public StringValue? TicketNbr { get; set; }

		public StringValue? UOM { get; set; }

		public DecimalValue? UnitCost { get; set; }

		public DecimalValue? UnitPrice { get; set; }

		public DateOnlyValue? WorkDate { get; set; }

		#endregion

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