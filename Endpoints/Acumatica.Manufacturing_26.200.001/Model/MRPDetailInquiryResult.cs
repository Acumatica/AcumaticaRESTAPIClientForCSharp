using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	[DataContract]
	public class MRPDetailInquiryResult : Entity
	{

		[DataMember(Name="ConsolidationID", EmitDefaultValue=false)]
		public StringValue? ConsolidationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Parent Inventory ID</para>
		/// </summary>
		[DataMember(Name="ParentInventoryID", EmitDefaultValue=false)]
		public StringValue? ParentInventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentSubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Parent Subitem</para>
		/// </summary>
		[DataMember(Name="ParentSubitem", EmitDefaultValue=false)]
		public StringValue? ParentSubitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Product Inventory ID</para>
		/// </summary>
		[DataMember(Name="ProductInventoryID", EmitDefaultValue=false)]
		public StringValue? ProductInventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductSubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Product Subitem</para>
		/// </summary>
		[DataMember(Name="ProductSubitem", EmitDefaultValue=false)]
		public StringValue? ProductSubitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Promise Date</para>
		/// </summary>
		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BaseQty</para>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// Qty on hand
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Qty. On Hand</para>
		/// </summary>
		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHand { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// Plan type related to the RefOrdertype and RefOrderNbr
		/// <para>DAC Field Name: RefType</para>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Reference Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="ReferenceType", EmitDefaultValue=false)]
		public StringValue? ReferenceType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Related Document</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// Planning Type
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

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