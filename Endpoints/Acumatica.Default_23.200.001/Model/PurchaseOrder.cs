using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PO301000</c> in the Acumatica ERP
	/// <para>Key Fields: OrderNbr, Type</para>
	/// </summary>
	public class PurchaseOrder : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: BaseCuryID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryControlTotal</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Control Total</para>
		/// </summary>
		public DecimalValue? ControlTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryEffDate</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public DateTimeValue? CurrencyEffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SampleCuryRate</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryRateTypeID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SampleRecipRate</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? CurrencyReciprocalRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderDate</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// </summary>
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderDesc</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<PurchaseOrderDetail>? Details { get; set; }

		public BooleanValue? Hold { get; set; }

		public BooleanValue? IsTaxValid { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public DecimalValue? LineTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryOrderTotal</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Order Total</para>
		/// </summary>
		public DecimalValue? OrderTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpectedDate</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Promised On</para>
		/// </summary>
		public DateTimeValue? PromisedOn { get; set; }

		public ShippingInstructions? ShippingInstructions { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public List<PurchaseOrderTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Tax Total</para>
		/// </summary>
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TermsID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? Terms { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderType</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Vendor</para>
		/// </summary>
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorRefNbr</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Vendor Ref.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? VendorRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxZoneID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Vendor Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? VendorTaxZone { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string ShippingInstructions = "ShippingInstructions";
			public const string ShippingInstructions_ShipToAddress = "ShippingInstructions/ShipToAddress";
			public const string ShippingInstructions_ShipToContact = "ShippingInstructions/ShipToContact";
			public const string TaxDetails = "TaxDetails";
			public const string TaxDetails_Files = "TaxDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files,ShippingInstructions,ShippingInstructions/ShipToAddress,ShippingInstructions/ShipToContact,TaxDetails,TaxDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}