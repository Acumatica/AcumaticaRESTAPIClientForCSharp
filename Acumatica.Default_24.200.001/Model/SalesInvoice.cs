using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen SO303000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class SalesInvoice : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryOrigDocAmt 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="ApplicationsCreditMemo", EmitDefaultValue=false)]
		public List<SalesInvoiceApplicationCreditMemo>? ApplicationsCreditMemo { get; set; }

		[DataMember(Name="ApplicationsInvoice", EmitDefaultValue=false)]
		public List<SalesInvoiceApplicationInvoice>? ApplicationsInvoice { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryDocBal 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		[DataMember(Name="BillingSettings", EmitDefaultValue=false)]
		public BillToSettings? BillingSettings { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryOrigDiscAmt 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CashDiscount", EmitDefaultValue=false)]
		public DecimalValue? CashDiscount { get; set; }

		[DataMember(Name="Commissions", EmitDefaultValue=false)]
		public SalesInvoiceCommissions? Commissions { get; set; }

		[DataMember(Name="CreditHold", EmitDefaultValue=false)]
		public BooleanValue? CreditHold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvoiceNbr 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DocDate 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<SalesInvoiceDetail>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryLineTotal 
		/// DAC: PX.Objects.SO.SOFreightDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DetailTotal", EmitDefaultValue=false)]
		public DecimalValue? DetailTotal { get; set; }

		[DataMember(Name="DiscountDetails", EmitDefaultValue=false)]
		public List<SalesInvoiceDiscountDetails>? DiscountDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryDiscTot 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DiscountTotal", EmitDefaultValue=false)]
		public DecimalValue? DiscountTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DueDate 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		[DataMember(Name="IsTaxValid", EmitDefaultValue=false)]
		public BooleanValue? IsTaxValid { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public SalesInvoiceFinancialDetails? FinancialDetails { get; set; }

		[DataMember(Name="FreightDetails", EmitDefaultValue=false)]
		public List<SalesInvoiceFreightDetail>? FreightDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryFreightAmt 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FreightPrice", EmitDefaultValue=false)]
		public DecimalValue? FreightPrice { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryPaymentTotal 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentTotal", EmitDefaultValue=false)]
		public DecimalValue? PaymentTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<SalesInvoiceTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DocType 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryVatExemptTotal 
		/// DAC: PX.Objects.AR.ARInvoice 
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
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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

		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

		[DataMember(Name="LastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDate { get; set; }

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public SalesInvoiceAddress? ShipToAddress { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.AR.ARShippingAddress 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressOverride { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public SalesInvoiceDocContact? ShipToContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.AR.ARShippingContact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToContactOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCalcMode 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxCalcMode", EmitDefaultValue=false)]
		public StringValue? TaxCalcMode { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}