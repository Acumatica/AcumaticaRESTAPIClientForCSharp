using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class WorkOrderDetail : Entity
	{

		#region Fields
		public DecimalValue? Amount { get; set; }

		public StringSingleSelectValue? BillingCategory { get; set; }

		public StringValue? Description { get; set; }

		public DecimalValue? DiscAmt { get; set; }

		public DecimalValue? DiscPct { get; set; }

		public StringValue? DiscountID { get; set; }

		public StringValue? DiscountSequenceID { get; set; }

		public DecimalValue? EstimatedQty { get; set; }

		public DecimalValue? ExtCost { get; set; }

		public DecimalValue? ExtPrice { get; set; }

		public StringValue? InventoryID { get; set; }

		public StringValue? ItemType { get; set; }

		public BooleanValue? ManualDisc { get; set; }

		public BooleanValue? ManualMarkup { get; set; }

		public BooleanValue? ManualPrice { get; set; }

		public DecimalValue? MarkupPct { get; set; }

		public StringSingleSelectValue? PriceRule { get; set; }

		public StringValue? SiteID { get; set; }

		public DecimalValue? TaxAmt { get; set; }

		public StringValue? TaxCategoryID { get; set; }

		public StringValue? UOM { get; set; }

		public DecimalValue? UnitCost { get; set; }

		public DecimalValue? UnitPrice { get; set; }

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