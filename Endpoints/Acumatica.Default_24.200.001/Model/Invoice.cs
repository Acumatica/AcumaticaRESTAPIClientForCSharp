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
	/// Corresponds to the screen <c>AR301000</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr, Type</para>
	/// </summary>
	[DataContract]
	public class Invoice : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The amount of the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryOrigDocAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="ApplicationsCreditMemo", EmitDefaultValue=false)]
		public List<InvoiceApplicationsCreditMemo>? ApplicationsCreditMemo { get; set; }

		[DataMember(Name="ApplicationsDefault", EmitDefaultValue=false)]
		public List<InvoiceApplicationsDefault>? ApplicationsDefault { get; set; }

		/// <summary>
		/// The open balance of the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryDocBal</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the document has been printed.
		/// <para>DAC Field Name: Printed</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Printed</para>
		/// </summary>
		[DataMember(Name="BillingPrinted", EmitDefaultValue=false)]
		public BooleanValue? BillingPrinted { get; set; }

		[DataMember(Name="BillToContact", EmitDefaultValue=false)]
		public DocContact? BillToContact { get; set; }

		/// <summary>
		/// If set to true, indicates that the contactoverrides the default Contact recordreferenced by the CustomerContactID field.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.AR.ARShippingContact</para>
		/// <para>Display Name: Override Contact</para>
		/// </summary>
		[DataMember(Name="BillToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? BillToContactOverride { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC: PX.Objects.EP.EPApproval</para>
		/// <para>Display Name: Assignment Date</para>
		/// </summary>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The identifier of the Customer record associated with the document.
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// The original reference number or ID assigned by the customer to the customer document.
		/// <para>DAC Field Name: InvoiceNbr</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Customer Order Nbr.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// The date of the document.
		/// <para>DAC Field Name: DocDate</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The description of the document.
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<InvoiceDetail>? Details { get; set; }

		[DataMember(Name="DiscountDetails", EmitDefaultValue=false)]
		public List<InvoiceDiscountDetail>? DiscountDetails { get; set; }

		/// <summary>
		/// The due date of the document.
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Due Date</para>
		/// </summary>
		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the AR account to which the document should be posted.The Cash account and Year-to-Date Net Income account cannot be selected as the value of this field.
		/// <para>DAC Field Name: ARAccountID</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: AR Account</para>
		/// </summary>
		[DataMember(Name="LinkARAccount", EmitDefaultValue=false)]
		public StringValue? LinkARAccount { get; set; }

		/// <summary>
		/// The identifier of the branch to which the document belongs.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Branch</para>
		/// </summary>
		[DataMember(Name="LinkBranch", EmitDefaultValue=false)]
		public StringValue? LinkBranch { get; set; }

		/// <summary>
		/// Identifier of the Location of the Customer.
		/// <para>DAC Field Name: CustomerLocationID</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// Financial Period of the document.
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// The identifier of the project associated with the documentor the non-project code, which indicates that the document is not related to any particular project.
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// The reference number of the document.This field is a part of the compound key of the document.
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact? ShipToContact { get; set; }

		/// <summary>
		/// If set to true, indicates that the contactoverrides the default Contact recordreferenced by the CustomerContactID field.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.AR.ARShippingContact</para>
		/// <para>Display Name: Override Contact</para>
		/// </summary>
		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToContactOverride { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<InvoiceTaxDetail>? TaxDetails { get; set; }

		[DataMember(Name="IsTaxValid", EmitDefaultValue=false)]
		public BooleanValue? IsTaxValid { get; set; }

		/// <summary>
		/// The total amount of tax associated with the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Tax Total</para>
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// The identifier of the Credit Terms object associated with the document.
		/// <para>DAC Field Name: TermsID</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// The type of the document.This field is a part of the compound key of the document.
		/// <para>DAC Field Name: DocType</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string ApplicationsCreditMemo = "ApplicationsCreditMemo";
			public const string ApplicationsCreditMemo_Files = "ApplicationsCreditMemo/Files";
			public const string ApplicationsDefault = "ApplicationsDefault";
			public const string ApplicationsDefault_Files = "ApplicationsDefault/Files";
			public const string BillToContact = "BillToContact";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string DiscountDetails = "DiscountDetails";
			public const string DiscountDetails_Files = "DiscountDetails/Files";
			public const string ShipToContact = "ShipToContact";
			public const string TaxDetails = "TaxDetails";
			public const string TaxDetails_Files = "TaxDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,ApplicationsCreditMemo,ApplicationsCreditMemo/Files,ApplicationsDefault,ApplicationsDefault/Files,BillToContact,Details,Details/Files,DiscountDetails,DiscountDetails/Files,ShipToContact,TaxDetails,TaxDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}