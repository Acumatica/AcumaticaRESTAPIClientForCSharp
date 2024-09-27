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
	public class DiscountBreakpointDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: Amount 
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Break Amount 
		/// </summary>
		[DataMember(Name="BreakAmount", EmitDefaultValue=false)]
		public DecimalValue? BreakAmount { get; set; }

		/// <summary>
		/// DAC Field Name: Quantity 
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Break Quantity 
		/// </summary>
		[DataMember(Name="BreakQty", EmitDefaultValue=false)]
		public DecimalValue? BreakQty { get; set; }

		/// <summary>
		/// DAC Field Name: Discount 
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Discount Amount 
		/// </summary>
		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		[DataMember(Name="DiscountDetailID", EmitDefaultValue=false)]
		public IntValue? DiscountDetailID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Discount Percent 
		/// </summary>
		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// DAC Field Name: LastDate 
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Effective Date 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Free Item Qty. 
		/// </summary>
		[DataMember(Name="FreeItemQty", EmitDefaultValue=false)]
		public DecimalValue? FreeItemQty { get; set; }

		/// <summary>
		/// DAC Field Name: LastAmount 
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Last Break Amount 
		/// </summary>
		[DataMember(Name="LastBreakAmount", EmitDefaultValue=false)]
		public DecimalValue? LastBreakAmount { get; set; }

		/// <summary>
		/// DAC Field Name: LastQuantity 
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Last Break Quantity 
		/// </summary>
		[DataMember(Name="LastBreakQty", EmitDefaultValue=false)]
		public DecimalValue? LastBreakQty { get; set; }

		/// <summary>
		/// DAC Field Name: LastDiscount 
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Last Discount Amount 
		/// </summary>
		[DataMember(Name="LastDiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? LastDiscountAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Last Discount Percent 
		/// </summary>
		[DataMember(Name="LastDiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? LastDiscountPercent { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Last Free Item Qty. 
		/// </summary>
		[DataMember(Name="LastFreeItemQty", EmitDefaultValue=false)]
		public DecimalValue? LastFreeItemQty { get; set; }

		/// <summary>
		/// DAC Field Name: PendingAmount 
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Pending Break Amount 
		/// </summary>
		[DataMember(Name="PendingBreakAmount", EmitDefaultValue=false)]
		public DecimalValue? PendingBreakAmount { get; set; }

		/// <summary>
		/// DAC Field Name: PendingQuantity 
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Pending Break Quantity 
		/// </summary>
		[DataMember(Name="PendingBreakQty", EmitDefaultValue=false)]
		public DecimalValue? PendingBreakQty { get; set; }

		/// <summary>
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.AR.DiscountSequence 
		/// Display Name: Effective Date 
		/// </summary>
		[DataMember(Name="PendingDate", EmitDefaultValue=false)]
		public DateTimeValue? PendingDate { get; set; }

		/// <summary>
		/// DAC Field Name: PendingDiscount 
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Pending Discount Amount 
		/// </summary>
		[DataMember(Name="PendingDiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? PendingDiscountAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Pending Discount Percent 
		/// </summary>
		[DataMember(Name="PendingDiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? PendingDiscountPercent { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.DiscountDetail 
		/// Display Name: Pending Free Item Qty. 
		/// </summary>
		[DataMember(Name="PendingFreeItemQty", EmitDefaultValue=false)]
		public DecimalValue? PendingFreeItemQty { get; set; }

	}
}