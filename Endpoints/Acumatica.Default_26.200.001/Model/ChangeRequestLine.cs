using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ChangeRequestLine : Entity
	{

		#region Fields
		public StringValue? AccountGroup { get; set; }

		public StringValue? CostCode { get; set; }

		public BooleanValue? CreateCommitment { get; set; }

		public StringValue? Description { get; set; }

		public DecimalValue? ExtCost { get; set; }

		public DecimalValue? ExtPrice { get; set; }

		public StringValue? InventoryID { get; set; }

		public DecimalValue? LineAmount { get; set; }

		public DecimalValue? LineMarkup { get; set; }

		public IntValue? LineNbr { get; set; }

		public IntValue? POLineNbr { get; set; }

		public StringValue? PONbr { get; set; }

		public StringValue? POType { get; set; }

		public DecimalValue? PriceMarkup { get; set; }

		public StringValue? ProjectTask { get; set; }

		public DecimalValue? Quantity { get; set; }

		public StringValue? ReferenceNbr { get; set; }

		public StringValue? RevenueAccountGroup { get; set; }

		public StringValue? RevenueCode { get; set; }

		public StringValue? RevenueInventoryID { get; set; }

		public StringValue? RevenueTask { get; set; }

		public StringValue? RevenueTaxCategory { get; set; }

		public StringValue? Status { get; set; }

		public StringValue? Subitem { get; set; }

		public DecimalValue? UnitCost { get; set; }

		public DecimalValue? UnitPrice { get; set; }

		public StringValue? UOM { get; set; }

		public StringValue? Vendor { get; set; }

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