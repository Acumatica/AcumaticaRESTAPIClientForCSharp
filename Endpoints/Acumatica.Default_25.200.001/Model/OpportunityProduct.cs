using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class OpportunityProduct : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryAmount</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Detail Total</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscPct</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Discount, %</para>
		/// </summary>
		[DataMember(Name="Discount", EmitDefaultValue=false)]
		public DecimalValue? Discount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscAmt</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Discount Amount</para>
		/// </summary>
		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Discount Code</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue? DiscountCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountSequenceID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Discount Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DiscountSequence", EmitDefaultValue=false)]
		public StringValue? DiscountSequence { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryExtPrice</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Ext. Price</para>
		/// </summary>
		[DataMember(Name="ExternalPrice", EmitDefaultValue=false)]
		public DecimalValue? ExternalPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsFree</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Free Item</para>
		/// </summary>
		[DataMember(Name="FreeItem", EmitDefaultValue=false)]
		public BooleanValue? FreeItem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ManualDisc</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Manual Discount</para>
		/// </summary>
		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue? ManualDiscount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineNbr</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OpportunityProductID", EmitDefaultValue=false)]
		public IntValue? OpportunityProductID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Quantity</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnitPrice</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Unit Price</para>
		/// </summary>
		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// Indicates (if selected) that the automatic line discounts are not applied to this line.
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Ignore Automatic Line Discounts</para>
		/// </summary>
		[DataMember(Name="SkipLineDiscounts", EmitDefaultValue=false)]
		public BooleanValue? SkipLineDiscounts { get; set; }

	}
}