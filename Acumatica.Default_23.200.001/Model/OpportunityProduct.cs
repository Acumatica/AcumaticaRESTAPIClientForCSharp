using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class OpportunityProduct : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryAmount 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// Display Name: Detail Total 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// DAC Field Name: DiscPct 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Discount, % 
		/// </summary>
		[DataMember(Name="Discount", EmitDefaultValue=false)]
		public DecimalValue? Discount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDiscAmt 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Discount Amount 
		/// </summary>
		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountID 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Discount Code 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue? DiscountCode { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountSequenceID 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Discount Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="DiscountSequence", EmitDefaultValue=false)]
		public StringValue? DiscountSequence { get; set; }

		/// <summary>
		/// DAC Field Name: CuryExtPrice 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Ext. Price 
		/// </summary>
		[DataMember(Name="ExternalPrice", EmitDefaultValue=false)]
		public DecimalValue? ExternalPrice { get; set; }

		/// <summary>
		/// DAC Field Name: IsFree 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Free Item 
		/// </summary>
		[DataMember(Name="FreeItem", EmitDefaultValue=false)]
		public BooleanValue? FreeItem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ManualDisc 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Manual Discount 
		/// </summary>
		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue? ManualDiscount { get; set; }

		/// <summary>
		/// DAC Field Name: LineNbr 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="OpportunityProductID", EmitDefaultValue=false)]
		public IntValue? OpportunityProductID { get; set; }

		/// <summary>
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// DAC Field Name: Quantity 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Quantity 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// DAC Field Name: CuryUnitPrice 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Unit Price 
		/// </summary>
		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.CR.CROpportunity 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// Indicates (if selected) that the automatic line discounts are not applied to this line.
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Ignore Automatic Line Discounts 
		/// </summary>
		[DataMember(Name="SkipLineDiscounts", EmitDefaultValue=false)]
		public BooleanValue? SkipLineDiscounts { get; set; }

	}
}