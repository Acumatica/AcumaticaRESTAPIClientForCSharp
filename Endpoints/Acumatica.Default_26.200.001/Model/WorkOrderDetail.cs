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
	public class WorkOrderDetail : Entity
	{

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="BillingCategory", EmitDefaultValue=false)]
		public StringSingleSelectValue? BillingCategory { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DiscAmt", EmitDefaultValue=false)]
		public DecimalValue? DiscAmt { get; set; }

		[DataMember(Name="DiscPct", EmitDefaultValue=false)]
		public DecimalValue? DiscPct { get; set; }

		[DataMember(Name="DiscountID", EmitDefaultValue=false)]
		public StringValue? DiscountID { get; set; }

		[DataMember(Name="DiscountSequenceID", EmitDefaultValue=false)]
		public StringValue? DiscountSequenceID { get; set; }

		[DataMember(Name="EstimatedQty", EmitDefaultValue=false)]
		public DecimalValue? EstimatedQty { get; set; }

		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

		[DataMember(Name="ExtPrice", EmitDefaultValue=false)]
		public DecimalValue? ExtPrice { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="ItemType", EmitDefaultValue=false)]
		public StringValue? ItemType { get; set; }

		[DataMember(Name="ManualDisc", EmitDefaultValue=false)]
		public BooleanValue? ManualDisc { get; set; }

		[DataMember(Name="ManualMarkup", EmitDefaultValue=false)]
		public BooleanValue? ManualMarkup { get; set; }

		[DataMember(Name="ManualPrice", EmitDefaultValue=false)]
		public BooleanValue? ManualPrice { get; set; }

		[DataMember(Name="MarkupPct", EmitDefaultValue=false)]
		public DecimalValue? MarkupPct { get; set; }

		[DataMember(Name="PriceRule", EmitDefaultValue=false)]
		public StringSingleSelectValue? PriceRule { get; set; }

		[DataMember(Name="SiteID", EmitDefaultValue=false)]
		public StringValue? SiteID { get; set; }

		[DataMember(Name="TaxAmt", EmitDefaultValue=false)]
		public DecimalValue? TaxAmt { get; set; }

		[DataMember(Name="TaxCategoryID", EmitDefaultValue=false)]
		public StringValue? TaxCategoryID { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

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