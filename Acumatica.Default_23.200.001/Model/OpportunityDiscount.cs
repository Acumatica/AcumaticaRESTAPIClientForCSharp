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
	public class OpportunityDiscount : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryDiscountableAmt 
		/// DAC: PX.Objects.CR.CROpportunityDiscountDetail 
		/// Display Name: Discountable Amt. 
		/// </summary>
		[DataMember(Name="DiscountableAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountableAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CROpportunityDiscountDetail 
		/// Display Name: Discountable Qty. 
		/// </summary>
		[DataMember(Name="DiscountableQty", EmitDefaultValue=false)]
		public DecimalValue? DiscountableQty { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDiscountAmt 
		/// DAC: PX.Objects.CR.CROpportunityDiscountDetail 
		/// Display Name: Discount Amt. 
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
		/// DAC Field Name: DiscountPct 
		/// DAC: PX.Objects.CR.CROpportunityDiscountDetail 
		/// Display Name: Discount Percent 
		/// </summary>
		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// DAC Field Name: FreeItemID 
		/// DAC: PX.Objects.CR.CROpportunityDiscountDetail 
		/// Display Name: Free Item 
		/// </summary>
		[DataMember(Name="FreeItem", EmitDefaultValue=false)]
		public StringValue? FreeItem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CROpportunityDiscountDetail 
		/// Display Name: Free Item Qty. 
		/// </summary>
		[DataMember(Name="FreeItemQty", EmitDefaultValue=false)]
		public DecimalValue? FreeItemQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: IsManual 
		/// DAC: PX.Objects.CR.CROpportunityDiscountDetail 
		/// Display Name: Manual Discount 
		/// </summary>
		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue? ManualDiscount { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountSequenceID 
		/// DAC: PX.Objects.CR.CROpportunityProducts 
		/// Display Name: Discount Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="SequenceID", EmitDefaultValue=false)]
		public StringValue? SequenceID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CROpportunityDiscountDetail 
		/// Display Name: Skip Discount 
		/// </summary>
		[DataMember(Name="SkipDiscount", EmitDefaultValue=false)]
		public BooleanValue? SkipDiscount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CROpportunityDiscountDetail 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}