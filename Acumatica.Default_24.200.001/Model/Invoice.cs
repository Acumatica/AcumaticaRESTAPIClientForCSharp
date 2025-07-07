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
	/// Corresponds to the screen AR301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Invoice : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The amount of the document.Given in the currency of the document.
		/// DAC Field Name: CuryOrigDocAmt 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="ApplicationsCreditMemo", EmitDefaultValue=false)]
		public List<InvoiceApplicationsCreditMemo>? ApplicationsCreditMemo { get; set; }

		[DataMember(Name="ApplicationsDefault", EmitDefaultValue=false)]
		public List<InvoiceApplicationsDefault>? ApplicationsDefault { get; set; }

		/// <summary>
		/// The open balance of the document.Given in the currency of the document.
		/// DAC Field Name: CuryDocBal 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the document has been printed.
		/// DAC Field Name: Printed 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Printed 
		/// </summary>
		[DataMember(Name="BillingPrinted", EmitDefaultValue=false)]
		public BooleanValue? BillingPrinted { get; set; }

		[DataMember(Name="BillToContact", EmitDefaultValue=false)]
		public DocContact? BillToContact { get; set; }

		/// <summary>
		/// If set to true, indicates that the contactoverrides the default Contact recordreferenced by the CustomerContactID field.
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.AR.ARShippingContact 
		/// Display Name: Override Contact 
		/// </summary>
		[DataMember(Name="BillToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? BillToContactOverride { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC: PX.Objects.EP.EPApproval 
		/// Display Name: Assignment Date 
		/// </summary>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The identifier of the Customer record associated with the document.
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

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
		public List<InvoiceDetail>? Details { get; set; }

		[DataMember(Name="DiscountDetails", EmitDefaultValue=false)]
		public List<InvoiceDiscountDetail>? DiscountDetails { get; set; }

		/// <summary>
		/// The due date of the document.
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Due Date 
		/// </summary>
		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the AR account to which the document should be posted.The Cash account and Year-to-Date Net Income account cannot be selected as the value of this field.
		/// DAC Field Name: ARAccountID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: AR Account 
		/// </summary>
		[DataMember(Name="LinkARAccount", EmitDefaultValue=false)]
		public StringValue? LinkARAccount { get; set; }

		/// <summary>
		/// The identifier of the branch to which the document belongs.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Branch 
		/// </summary>
		[DataMember(Name="LinkBranch", EmitDefaultValue=false)]
		public StringValue? LinkBranch { get; set; }

		/// <summary>
		/// Identifier of the Location of the Customer.
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// Financial Period of the document.
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Post Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

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

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact? ShipToContact { get; set; }

		/// <summary>
		/// If set to true, indicates that the contactoverrides the default Contact recordreferenced by the CustomerContactID field.
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.AR.ARShippingContact 
		/// Display Name: Override Contact 
		/// </summary>
		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToContactOverride { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<InvoiceTaxDetail>? TaxDetails { get; set; }

		[DataMember(Name="IsTaxValid", EmitDefaultValue=false)]
		public BooleanValue? IsTaxValid { get; set; }

		/// <summary>
		/// The total amount of tax associated with the document.Given in the currency of the document.
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// The identifier of the Credit Terms object associated with the document.
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// The type of the document.This field is a part of the compound key of the document.
		/// DAC Field Name: DocType 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}