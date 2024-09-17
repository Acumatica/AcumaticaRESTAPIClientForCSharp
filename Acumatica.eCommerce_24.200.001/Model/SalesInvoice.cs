using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class SalesInvoice : Entity, ITopLevelEntity
	{

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="ApplicationsCreditMemo", EmitDefaultValue=false)]
		public List<SalesInvoiceApplicationCreditMemo>? ApplicationsCreditMemo { get; set; }

		[DataMember(Name="ApplicationsInvoice", EmitDefaultValue=false)]
		public List<SalesInvoiceApplicationInvoice>? ApplicationsInvoice { get; set; }

		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		[DataMember(Name="BillingSettings", EmitDefaultValue=false)]
		public BillToSettings? BillingSettings { get; set; }

		[DataMember(Name="CashDiscount", EmitDefaultValue=false)]
		public DecimalValue? CashDiscount { get; set; }

		[DataMember(Name="Commissions", EmitDefaultValue=false)]
		public SalesInvoiceCommissions? Commissions { get; set; }

		[DataMember(Name="CreditHold", EmitDefaultValue=false)]
		public BooleanValue? CreditHold { get; set; }

		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<SalesInvoiceDetail>? Details { get; set; }

		[DataMember(Name="DetailTotal", EmitDefaultValue=false)]
		public DecimalValue? DetailTotal { get; set; }

		[DataMember(Name="DiscountDetails", EmitDefaultValue=false)]
		public List<SalesInvoiceDiscountDetails>? DiscountDetails { get; set; }

		[DataMember(Name="DiscountTotal", EmitDefaultValue=false)]
		public DecimalValue? DiscountTotal { get; set; }

		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		[DataMember(Name="IsTaxValid", EmitDefaultValue=false)]
		public BooleanValue? IsTaxValid { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public SalesInvoiceFinancialDetails? FinancialDetails { get; set; }

		[DataMember(Name="FreightDetails", EmitDefaultValue=false)]
		public List<SalesInvoiceFreightDetail>? FreightDetails { get; set; }

		[DataMember(Name="FreightPrice", EmitDefaultValue=false)]
		public DecimalValue? FreightPrice { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="PaymentTotal", EmitDefaultValue=false)]
		public DecimalValue? PaymentTotal { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<SalesInvoiceTaxDetail>? TaxDetails { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="VATExemptTotal", EmitDefaultValue=false)]
		public DecimalValue? VATExemptTotal { get; set; }

		[DataMember(Name="VATTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue? VATTaxableTotal { get; set; }

		[DataMember(Name="BillToAddress", EmitDefaultValue=false)]
		public SalesInvoiceAddress? BillToAddress { get; set; }

		[DataMember(Name="BillToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? BillToAddressOverride { get; set; }

		[DataMember(Name="BillToContact", EmitDefaultValue=false)]
		public SalesInvoiceDocContact? BillToContact { get; set; }

		[DataMember(Name="BillToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? BillToContactOverride { get; set; }

		[DataMember(Name="CreatedDate", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDate { get; set; }

		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

		[DataMember(Name="LastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDate { get; set; }

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public SalesInvoiceAddress? ShipToAddress { get; set; }

		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressOverride { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public SalesInvoiceDocContact? ShipToContact { get; set; }

		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToContactOverride { get; set; }

		[DataMember(Name="TaxCalcMode", EmitDefaultValue=false)]
		public StringValue? TaxCalcMode { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}