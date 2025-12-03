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
	public class Totals : Entity
	{

		/// <summary>
		/// The total discount of the document (in the currency of the document),which is calculated as the sum of all discounts of the order.
		/// <para>DAC Field Name: CuryDiscTot</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Document Discounts</para>
		/// </summary>
		[DataMember(Name="DiscountTotal", EmitDefaultValue=false)]
		public DecimalValue? DiscountTotal { get; set; }

		[DataMember(Name="LineTotalAmount", EmitDefaultValue=false)]
		public DecimalValue? LineTotalAmount { get; set; }

		[DataMember(Name="MiscTotalAmount", EmitDefaultValue=false)]
		public DecimalValue? MiscTotalAmount { get; set; }

		/// <summary>
		/// The total amount of tax paid on the document (in the currency of the document).
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Tax Total</para>
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// The unbilled balance of the sales order, which is calculated asthe sum of the unbilled line amounts(in the currency of the document).
		/// <para>DAC Field Name: CuryUnbilledOrderTotal</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Unbilled Balance</para>
		/// </summary>
		[DataMember(Name="UnbilledAmount", EmitDefaultValue=false)]
		public DecimalValue? UnbilledAmount { get; set; }

		/// <summary>
		/// The quantity of stock and non-stock items that were not yet billed.
		/// <para>DAC Field Name: UnbilledOrderQty</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Unbilled Quantity</para>
		/// </summary>
		/// <remarks>
		/// This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="UnbilledQty", EmitDefaultValue=false)]
		public DecimalValue? UnbilledQty { get; set; }

		/// <summary>
		/// The unpaid amount of the order (in the currency of the document).
		/// <para>DAC Field Name: CuryUnpaidBalance</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Unpaid Balance</para>
		/// </summary>
		[DataMember(Name="UnpaidBalance", EmitDefaultValue=false)]
		public DecimalValue? UnpaidBalance { get; set; }

		/// <summary>
		/// The freight amount calculated in accordance withthe shipping terms (in the currency of the document).
		/// <para>DAC Field Name: CuryFreightAmt</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Freight Price</para>
		/// </summary>
		[DataMember(Name="Freight", EmitDefaultValue=false)]
		public DecimalValue? Freight { get; set; }

		/// <summary>
		/// The freight cost calculated for the document(in the currency of the document).
		/// <para>DAC Field Name: CuryFreightCost</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Freight Cost</para>
		/// </summary>
		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the freight rates are up to date.
		/// <para>DAC Field Name: FreightCostIsValid</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Freight Cost Is up-to-date</para>
		/// </summary>
		[DataMember(Name="FreightCostIsuptodate", EmitDefaultValue=false)]
		public BooleanValue? FreightCostIsuptodate { get; set; }

		/// <summary>
		/// The identifier of the tax category that applies to the total freight amount.The field is included in the FreightTaxCategory foreign key.
		/// <para>DAC Field Name: FreightTaxCategoryID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Freight Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		/// <remarks>
		/// The default value is the tax category associated with the ship via codeship via code of the order.This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="FreightTaxCategory", EmitDefaultValue=false)]
		public StringValue? FreightTaxCategory { get; set; }

		/// <summary>
		/// The total volume of goods according to the document.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Order Volume</para>
		/// </summary>
		[DataMember(Name="OrderVolume", EmitDefaultValue=false)]
		public DecimalValue? OrderVolume { get; set; }

		/// <summary>
		/// The total weight of the goods according to the document.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Order Weight</para>
		/// </summary>
		[DataMember(Name="OrderWeight", EmitDefaultValue=false)]
		public DecimalValue? OrderWeight { get; set; }

		/// <summary>
		/// The total (gross) weight of the packages for this sales order, including the weight of the boxes used forpackages.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Package Weight</para>
		/// </summary>
		[DataMember(Name="PackageWeight", EmitDefaultValue=false)]
		public DecimalValue? PackageWeight { get; set; }

		/// <summary>
		/// Any additional freight charges for handling the order(in the currency of the document).
		/// <para>DAC Field Name: CuryPremiumFreightAmt</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Premium Freight Price</para>
		/// </summary>
		[DataMember(Name="PremiumFreight", EmitDefaultValue=false)]
		public DecimalValue? PremiumFreight { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the Freight Price can be changedmanually.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Override Freight Price</para>
		/// </summary>
		/// <remarks>
		/// The system will preserve the manually entered Freight Price value inthe sales order and will not recalculate the value if the quantity, extended price, or amount is modifiedin order lines.
		/// </remarks>
		[DataMember(Name="OverrideFreightAmount", EmitDefaultValue=false)]
		public BooleanValue? OverrideFreightAmount { get; set; }

	}
}