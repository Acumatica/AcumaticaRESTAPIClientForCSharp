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
	public class ChangeRequestLine : Entity
	{

		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		[DataMember(Name="CreateCommitment", EmitDefaultValue=false)]
		public BooleanValue? CreateCommitment { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

		[DataMember(Name="ExtPrice", EmitDefaultValue=false)]
		public DecimalValue? ExtPrice { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LineAmount", EmitDefaultValue=false)]
		public DecimalValue? LineAmount { get; set; }

		[DataMember(Name="LineMarkup", EmitDefaultValue=false)]
		public DecimalValue? LineMarkup { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="POLineNbr", EmitDefaultValue=false)]
		public IntValue? POLineNbr { get; set; }

		[DataMember(Name="PONbr", EmitDefaultValue=false)]
		public StringValue? PONbr { get; set; }

		[DataMember(Name="POType", EmitDefaultValue=false)]
		public StringValue? POType { get; set; }

		[DataMember(Name="PriceMarkup", EmitDefaultValue=false)]
		public DecimalValue? PriceMarkup { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="RevenueAccountGroup", EmitDefaultValue=false)]
		public StringValue? RevenueAccountGroup { get; set; }

		[DataMember(Name="RevenueCode", EmitDefaultValue=false)]
		public StringValue? RevenueCode { get; set; }

		[DataMember(Name="RevenueInventoryID", EmitDefaultValue=false)]
		public StringValue? RevenueInventoryID { get; set; }

		[DataMember(Name="RevenueTask", EmitDefaultValue=false)]
		public StringValue? RevenueTask { get; set; }

		[DataMember(Name="RevenueTaxCategory", EmitDefaultValue=false)]
		public StringValue? RevenueTaxCategory { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

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