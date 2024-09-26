using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen SO301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class SalesOrder : Entity, ITopLevelEntity
	{

		[DataMember(Name="Approved", EmitDefaultValue=false)]
		public BooleanValue? Approved { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseCuryID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		[DataMember(Name="BillToAddress", EmitDefaultValue=false)]
		public Address? BillToAddress { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.SO.SOBillingAddress 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BillToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? BillToAddressOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsValidated 
		/// DAC: PX.Objects.SO.SOBillingAddress 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BillToAddressValidated", EmitDefaultValue=false)]
		public BooleanValue? BillToAddressValidated { get; set; }

		[DataMember(Name="BillToContact", EmitDefaultValue=false)]
		public DocContact? BillToContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.SO.SOBillingContact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BillToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? BillToContactOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="Commissions", EmitDefaultValue=false)]
		public Commissions? Commissions { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ContactID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public StringValue? ContactID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryControlTotal 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ControlTotal", EmitDefaultValue=false)]
		public DecimalValue? ControlTotal { get; set; }

		[DataMember(Name="CreditHold", EmitDefaultValue=false)]
		public BooleanValue? CreditHold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SampleCuryRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerOrderNbr 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderDate 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderDesc 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DestinationSiteID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DestinationWarehouseID", EmitDefaultValue=false)]
		public StringValue? DestinationWarehouseID { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<SalesOrderDetail>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DisableAutomaticDiscountCalculation 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DisableAutomaticDiscountUpdate", EmitDefaultValue=false)]
		public BooleanValue? DisableAutomaticDiscountUpdate { get; set; }

		[DataMember(Name="DiscountDetails", EmitDefaultValue=false)]
		public List<SalesOrdersDiscountDetails>? DiscountDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryEffDate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerRefNbr 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

		[DataMember(Name="FinancialSettings", EmitDefaultValue=false)]
		public FinancialSettings? FinancialSettings { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="IsTaxValid", EmitDefaultValue=false)]
		public BooleanValue? IsTaxValid { get; set; }

		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue? LastModified { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderQty 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderedQty", EmitDefaultValue=false)]
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderNbr 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryOrderTotal 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderTotal", EmitDefaultValue=false)]
		public DecimalValue? OrderTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		[DataMember(Name="Payments", EmitDefaultValue=false)]
		public List<SalesOrderPayment>? Payments { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultSiteID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PreferredWarehouseID", EmitDefaultValue=false)]
		public StringValue? PreferredWarehouseID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SampleRecipRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? ReciprocalRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RequestDate 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequestedOn", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOn { get; set; }

		[DataMember(Name="Shipments", EmitDefaultValue=false)]
		public List<SalesOrderShipment>? Shipments { get; set; }

		[DataMember(Name="ShippingSettings", EmitDefaultValue=false)]
		public ShippingSettings? ShippingSettings { get; set; }

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public Address? ShipToAddress { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.SO.SOBillingAddress 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsValidated 
		/// DAC: PX.Objects.SO.SOBillingAddress 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShipToAddressValidated", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressValidated { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact? ShipToContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.SO.SOBillingContact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToContactOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipVia 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<TaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public Totals? Totals { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryVatExemptTotal 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VATExemptTotal", EmitDefaultValue=false)]
		public DecimalValue? VATExemptTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryVatTaxableTotal 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VATTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue? VATTaxableTotal { get; set; }

		[DataMember(Name="ExternalOrderOriginal", EmitDefaultValue=false)]
		public BooleanValue? ExternalOrderOriginal { get; set; }

		[DataMember(Name="ExternalRefundRef", EmitDefaultValue=false)]
		public StringValue? ExternalRefundRef { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WillCall 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WillCall", EmitDefaultValue=false)]
		public BooleanValue? WillCall { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="UsrExternalOrderOriginal", EmitDefaultValue=false)]
		public BooleanValue? UsrExternalOrderOriginal { get; set; }

		[DataMember(Name="ExternalOrderOrigin", EmitDefaultValue=false)]
		public StringValue? ExternalOrderOrigin { get; set; }

		[DataMember(Name="ExternalOrderSource", EmitDefaultValue=false)]
		public StringValue? ExternalOrderSource { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCalcMode 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxCalcMode", EmitDefaultValue=false)]
		public StringValue? TaxCalcMode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.EP.EPApproval 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CreatedDate", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DisableAutomaticTaxCalculation 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DisableAutomaticTaxCalculation", EmitDefaultValue=false)]
		public BooleanValue? DisableAutomaticTaxCalculation { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}