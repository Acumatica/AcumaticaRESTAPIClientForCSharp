using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class WorkOrderDiscountDetail : Entity
	{

		#region Fields
		public StringValue? Description { get; set; }

		public DecimalValue? DiscountAmt { get; set; }

		public StringValue? DiscountID { get; set; }

		public DecimalValue? DiscountPct { get; set; }

		public StringValue? DiscountSequenceID { get; set; }

		public DecimalValue? DiscountableAmt { get; set; }

		public DecimalValue? DiscountableQty { get; set; }

		public StringValue? ExtDiscCode { get; set; }

		public StringValue? FreeItemID { get; set; }

		public DecimalValue? FreeItemQty { get; set; }

		public BooleanValue? Manual { get; set; }

		public BooleanValue? SkipDiscount { get; set; }

		public StringSingleSelectValue? Type { get; set; }

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