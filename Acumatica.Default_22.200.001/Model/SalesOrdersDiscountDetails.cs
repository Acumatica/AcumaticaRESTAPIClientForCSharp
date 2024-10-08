using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class SalesOrdersDiscountDetails : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.SO.SOOrderDiscountDetail 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDiscountableAmt 
		/// DAC: PX.Objects.SO.SOOrderDiscountDetail 
		/// Display Name: Discountable Amt. 
		/// </summary>
		[DataMember(Name="DiscountableAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountableAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOOrderDiscountDetail 
		/// Display Name: Discountable Qty. 
		/// </summary>
		[DataMember(Name="DiscountableQty", EmitDefaultValue=false)]
		public DecimalValue? DiscountableQty { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDiscountAmt 
		/// DAC: PX.Objects.SO.SOOrderDiscountDetail 
		/// Display Name: Discount Amt. 
		/// </summary>
		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// The code of the discount of the line.
		/// DAC Field Name: DiscountID 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Discount Code 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		/// <remarks>
		/// The field is included in the following foreign keys:                        . The field is the identifier of the Discount            .            . The field is a part of the identifier of the Discount Sequence            .                        This field is available only if the            Customer Discounts            feature is enabled on the Enable/Disable Features (CS100000) form.            
		/// </remarks>
		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue? DiscountCode { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountPct 
		/// DAC: PX.Objects.SO.SOOrderDiscountDetail 
		/// Display Name: Discount Percent 
		/// </summary>
		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// DAC Field Name: ExtDiscCode 
		/// DAC: PX.Objects.SO.SOOrderDiscountDetail 
		/// Display Name: External Discount Code 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ExternalDiscountCode", EmitDefaultValue=false)]
		public StringValue? ExternalDiscountCode { get; set; }

		/// <summary>
		/// DAC Field Name: FreeItemID 
		/// DAC: PX.Objects.SO.SOOrderDiscountDetail 
		/// Display Name: Free Item 
		/// </summary>
		[DataMember(Name="FreeItem", EmitDefaultValue=false)]
		public StringValue? FreeItem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOOrderDiscountDetail 
		/// Display Name: Free Item Qty. 
		/// </summary>
		[DataMember(Name="FreeItemQty", EmitDefaultValue=false)]
		public DecimalValue? FreeItemQty { get; set; }

		/// <summary>
		/// DAC Field Name: IsManual 
		/// DAC: PX.Objects.SO.SOOrderDiscountDetail 
		/// Display Name: Manual Discount 
		/// </summary>
		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue? ManualDiscount { get; set; }

		/// <summary>
		/// The identifier of the discount sequence of the line.
		/// DAC Field Name: DiscountSequenceID 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Discount Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		/// <remarks>
		/// The field is included in the  foreign key. The field is a part ofthe identifier of the Discount Sequence..This field is available only if theCustomer Discountsfeature is enabled on the Enable/Disable Features (CS100000) form.
		/// </remarks>
		[DataMember(Name="SequenceID", EmitDefaultValue=false)]
		public StringValue? SequenceID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOOrderDiscountDetail 
		/// Display Name: Skip Discount 
		/// </summary>
		[DataMember(Name="SkipDiscount", EmitDefaultValue=false)]
		public BooleanValue? SkipDiscount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOOrderDiscountDetail 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}