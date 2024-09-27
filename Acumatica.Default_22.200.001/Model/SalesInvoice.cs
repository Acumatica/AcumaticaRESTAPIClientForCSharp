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
	/// Corresponds to the screen SO303000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class SalesInvoice : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The amount of the document.Given in the currency of the document.
		/// DAC Field Name: CuryOrigDocAmt 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="ApplicationsCreditMemo", EmitDefaultValue=false)]
		public List<SalesInvoiceApplicationCreditMemo>? ApplicationsCreditMemo { get; set; }

		[DataMember(Name="ApplicationsInvoice", EmitDefaultValue=false)]
		public List<SalesInvoiceApplicationInvoice>? ApplicationsInvoice { get; set; }

		/// <summary>
		/// The open balance of the document.Given in the currency of the document.
		/// DAC Field Name: CuryDocBal 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		[DataMember(Name="BillingSettings", EmitDefaultValue=false)]
		public BillToSettings? BillingSettings { get; set; }

		/// <summary>
		/// The cash discount entered for the document.Given in the currency of the document.
		/// DAC Field Name: CuryOrigDiscAmt 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Cash Discount 
		/// </summary>
		[DataMember(Name="CashDiscount", EmitDefaultValue=false)]
		public DecimalValue? CashDiscount { get; set; }

		[DataMember(Name="Commissions", EmitDefaultValue=false)]
		public SalesInvoiceCommissions? Commissions { get; set; }

		[DataMember(Name="CreditHold", EmitDefaultValue=false)]
		public BooleanValue? CreditHold { get; set; }

		/// <summary>
		/// The code of the Currency of the document.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// The identifier of the Customer record associated with the document.
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Customer 
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The original reference number or ID assigned by the customer to the customer document.
		/// DAC Field Name: InvoiceNbr 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Customer Order Nbr. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// The date of the document.
		/// DAC Field Name: DocDate 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The description of the document.
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// SQL Type: nvarchar(512) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<SalesInvoiceDetail>? Details { get; set; }

		/// <summary>
		/// DAC Field Name: CuryLineTotal 
		/// DAC: PX.Objects.SO.SOFreightDetail 
		/// Display Name: Line Total 
		/// </summary>
		[DataMember(Name="DetailTotal", EmitDefaultValue=false)]
		public DecimalValue? DetailTotal { get; set; }

		[DataMember(Name="DiscountDetails", EmitDefaultValue=false)]
		public List<SalesInvoiceDiscountDetails>? DiscountDetails { get; set; }

		/// <summary>
		/// The group and document discount total for the document.Given in the currency of the document.
		/// DAC Field Name: CuryDiscTot 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Group and Document Discount Total 
		/// </summary>
		[DataMember(Name="DiscountTotal", EmitDefaultValue=false)]
		public DecimalValue? DiscountTotal { get; set; }

		/// <summary>
		/// The due date of the document.
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Due Date 
		/// </summary>
		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		[DataMember(Name="IsTaxValid", EmitDefaultValue=false)]
		public BooleanValue? IsTaxValid { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public SalesInvoiceFinancialDetails? FinancialDetails { get; set; }

		[DataMember(Name="FreightDetails", EmitDefaultValue=false)]
		public List<SalesInvoiceFreightDetail>? FreightDetails { get; set; }

		/// <summary>
		/// The amount of freight associated with the document.Given in the currency of the document.
		/// DAC Field Name: CuryFreightAmt 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Freight Price 
		/// </summary>
		[DataMember(Name="FreightPrice", EmitDefaultValue=false)]
		public DecimalValue? FreightPrice { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// DAC Field Name: CuryPaymentTotal 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Total Paid 
		/// </summary>
		[DataMember(Name="PaymentTotal", EmitDefaultValue=false)]
		public DecimalValue? PaymentTotal { get; set; }

		/// <summary>
		/// The identifier of the project associated with the documentor the non-project code, which indicates that the document is not related to any particular project.
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// The reference number of the document.This field is a part of the compound key of the document.
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARInvoice 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<SalesInvoiceTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The total amount of tax associated with the document.Given in the currency of the document.
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// The type of the document.This field is a part of the compound key of the document.
		/// DAC Field Name: DocType 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// The portion of the document total that is exempt from VAT.Given in the currency of the document.This field is relevant only if the VAT Reporting feature is enabled.
		/// DAC Field Name: CuryVatExemptTotal 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Tax Exempt Total 
		/// </summary>
		[DataMember(Name="VATExemptTotal", EmitDefaultValue=false)]
		public DecimalValue? VATExemptTotal { get; set; }

		/// <summary>
		/// The portion of the document total that is subjected to VAT.Given in the currency of the document.This field is relevant only if the VAT Reporting feature is enabled.
		/// DAC Field Name: CuryVatTaxableTotal 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Taxable Total 
		/// </summary>
		[DataMember(Name="VATTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue? VATTaxableTotal { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}