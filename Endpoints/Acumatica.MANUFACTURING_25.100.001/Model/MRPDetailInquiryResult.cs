using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class MRPDetailInquiryResult : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Parent Inventory ID</para>
		/// </summary>
		public StringValue? ParentInventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentSubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Parent Subitem</para>
		/// </summary>
		public StringValue? ParentSubitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Product Inventory ID</para>
		/// </summary>
		public StringValue? ProductInventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductSubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Product Subitem</para>
		/// </summary>
		public StringValue? ProductSubitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Promise Date</para>
		/// </summary>
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BaseQty</para>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// Qty on hand
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Qty. On Hand</para>
		/// </summary>
		public DecimalValue? QtyOnHand { get; set; }

		public IntValue? RecordID { get; set; }

		/// <summary>
		/// Plan type related to the RefOrdertype and RefOrderNbr
		/// <para>DAC Field Name: RefType</para>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Reference Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? ReferenceType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>Display Name: Related Document</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// Planning Type
		/// <para>DAC: PX.Objects.AM.AMRPPlan</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Type { get; set; }

	}
}