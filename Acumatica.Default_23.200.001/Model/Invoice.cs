using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Invoice : Entity, ITopLevelEntity
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
		public List<InvoiceApplicationsCreditMemo>? ApplicationsCreditMemo { get; set; }

		[DataMember(Name="ApplicationsDefault", EmitDefaultValue=false)]
		public List<InvoiceApplicationsDefault>? ApplicationsDefault { get; set; }

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

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Printed 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BillingPrinted", EmitDefaultValue=false)]
		public BooleanValue? BillingPrinted { get; set; }

		[DataMember(Name="BillToContact", EmitDefaultValue=false)]
		public DocContact? BillToContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.AR.ARShippingContact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

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
		public List<InvoiceDetail>? Details { get; set; }

		[DataMember(Name="DiscountDetails", EmitDefaultValue=false)]
		public List<InvoiceDiscountDetail>? DiscountDetails { get; set; }

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

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ARAccountID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LinkARAccount", EmitDefaultValue=false)]
		public StringValue? LinkARAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LinkBranch", EmitDefaultValue=false)]
		public StringValue? LinkBranch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

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

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact? ShipToContact { get; set; }

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

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<InvoiceTaxDetail>? TaxDetails { get; set; }

		[DataMember(Name="IsTaxValid", EmitDefaultValue=false)]
		public BooleanValue? IsTaxValid { get; set; }

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
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

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

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}