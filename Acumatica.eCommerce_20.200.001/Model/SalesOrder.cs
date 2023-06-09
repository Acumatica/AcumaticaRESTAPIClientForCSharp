using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class SalesOrder : Entity
	{

		[DataMember(Name="OrderRisks", EmitDefaultValue=false)]
		public List<OrderRisks> OrderRisks { get; set; }

		[DataMember(Name="MaxRiskScore", EmitDefaultValue=false)]
		public DecimalValue MaxRiskScore { get; set; }

		[DataMember(Name="ExternalOrderOriginal", EmitDefaultValue=false)]
		public BooleanValue ExternalOrderOriginal { get; set; }

		[DataMember(Name="ExternalRefundRef", EmitDefaultValue=false)]
		public StringValue ExternalRefundRef { get; set; }

		[DataMember(Name="WillCall", EmitDefaultValue=false)]
		public BooleanValue WillCall { get; set; }

		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue PaymentRef { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

		[DataMember(Name="UsrExternalOrderOriginal", EmitDefaultValue=false)]
		public BooleanValue UsrExternalOrderOriginal { get; set; }

		[DataMember(Name="ExternalOrderOrigin", EmitDefaultValue=false)]
		public StringValue ExternalOrderOrigin { get; set; }

		[DataMember(Name="ExternalOrderSource", EmitDefaultValue=false)]
		public StringValue ExternalOrderSource { get; set; }

		[DataMember(Name="TaxCalcMode", EmitDefaultValue=false)]
		public StringValue TaxCalcMode { get; set; }

		[DataMember(Name="Approved", EmitDefaultValue=false)]
		public BooleanValue Approved { get; set; }

		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue BaseCurrencyID { get; set; }

		[DataMember(Name="BillToAddress", EmitDefaultValue=false)]
		public Address BillToAddress { get; set; }

		[DataMember(Name="BillToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue BillToAddressOverride { get; set; }

		[DataMember(Name="BillToAddressValidated", EmitDefaultValue=false)]
		public BooleanValue BillToAddressValidated { get; set; }

		[DataMember(Name="BillToContact", EmitDefaultValue=false)]
		public DocContact BillToContact { get; set; }

		[DataMember(Name="BillToContactOverride", EmitDefaultValue=false)]
		public BooleanValue BillToContactOverride { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue CashAccount { get; set; }

		[DataMember(Name="Commissions", EmitDefaultValue=false)]
		public Commissions Commissions { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public StringValue ContactID { get; set; }

		[DataMember(Name="ControlTotal", EmitDefaultValue=false)]
		public DecimalValue ControlTotal { get; set; }

		[DataMember(Name="CreditHold", EmitDefaultValue=false)]
		public BooleanValue CreditHold { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue CurrencyRate { get; set; }

		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue CurrencyRateTypeID { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue CustomerID { get; set; }

		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue CustomerOrder { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DestinationWarehouseID", EmitDefaultValue=false)]
		public StringValue DestinationWarehouseID { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<SalesOrderDetail> Details { get; set; }

		[DataMember(Name="DisableAutomaticDiscountUpdate", EmitDefaultValue=false)]
		public BooleanValue DisableAutomaticDiscountUpdate { get; set; }

		[DataMember(Name="DiscountDetails", EmitDefaultValue=false)]
		public List<SalesOrdersDiscountDetails> DiscountDetails { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue ExternalRef { get; set; }

		[DataMember(Name="FinancialSettings", EmitDefaultValue=false)]
		public FinancialSettings FinancialSettings { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="IsTaxValid", EmitDefaultValue=false)]
		public BooleanValue IsTaxValid { get; set; }

		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue LastModified { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue LocationID { get; set; }

		[DataMember(Name="OrderedQty", EmitDefaultValue=false)]
		public DecimalValue OrderedQty { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue OrderNbr { get; set; }

		[DataMember(Name="OrderTotal", EmitDefaultValue=false)]
		public DecimalValue OrderTotal { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue PaymentMethod { get; set; }

		[DataMember(Name="Payments", EmitDefaultValue=false)]
		public List<SalesOrderPayment> Payments { get; set; }

		[DataMember(Name="PreferredWarehouseID", EmitDefaultValue=false)]
		public StringValue PreferredWarehouseID { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue ReciprocalRate { get; set; }

		[DataMember(Name="RequestedOn", EmitDefaultValue=false)]
		public DateTimeValue RequestedOn { get; set; }

		[DataMember(Name="Shipments", EmitDefaultValue=false)]
		public List<SalesOrderShipment> Shipments { get; set; }

		[DataMember(Name="ShippingSettings", EmitDefaultValue=false)]
		public ShippingSettings ShippingSettings { get; set; }

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public Address ShipToAddress { get; set; }

		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue ShipToAddressOverride { get; set; }

		[DataMember(Name="ShipToAddressValidated", EmitDefaultValue=false)]
		public BooleanValue ShipToAddressValidated { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact ShipToContact { get; set; }

		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue ShipToContactOverride { get; set; }

		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue ShipVia { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<TaxDetail> TaxDetails { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue TaxTotal { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public Totals Totals { get; set; }

		[DataMember(Name="VATExemptTotal", EmitDefaultValue=false)]
		public DecimalValue VATExemptTotal { get; set; }

		[DataMember(Name="VATTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue VATTaxableTotal { get; set; }

	}
}