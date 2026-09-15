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
	public class WorkOrderDiscountDetail : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DiscountAmt", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmt { get; set; }

		[DataMember(Name="DiscountID", EmitDefaultValue=false)]
		public StringValue? DiscountID { get; set; }

		[DataMember(Name="DiscountPct", EmitDefaultValue=false)]
		public DecimalValue? DiscountPct { get; set; }

		[DataMember(Name="DiscountSequenceID", EmitDefaultValue=false)]
		public StringValue? DiscountSequenceID { get; set; }

		[DataMember(Name="DiscountableAmt", EmitDefaultValue=false)]
		public DecimalValue? DiscountableAmt { get; set; }

		[DataMember(Name="DiscountableQty", EmitDefaultValue=false)]
		public DecimalValue? DiscountableQty { get; set; }

		[DataMember(Name="ExtDiscCode", EmitDefaultValue=false)]
		public StringValue? ExtDiscCode { get; set; }

		[DataMember(Name="FreeItemID", EmitDefaultValue=false)]
		public StringValue? FreeItemID { get; set; }

		[DataMember(Name="FreeItemQty", EmitDefaultValue=false)]
		public DecimalValue? FreeItemQty { get; set; }

		[DataMember(Name="Manual", EmitDefaultValue=false)]
		public BooleanValue? Manual { get; set; }

		[DataMember(Name="SkipDiscount", EmitDefaultValue=false)]
		public BooleanValue? SkipDiscount { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringSingleSelectValue? Type { get; set; }

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