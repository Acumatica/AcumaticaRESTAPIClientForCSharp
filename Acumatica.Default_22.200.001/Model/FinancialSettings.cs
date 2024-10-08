using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class FinancialSettings : Entity
	{

		/// <summary>
		/// A Boolean value that indicates whether the document should be billed separately (that is, it requires aseparate invoice).
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Bill Separately 
		/// </summary>
		/// <remarks>
		/// This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="BillSeparately", EmitDefaultValue=false)]
		public BooleanValue? BillSeparately { get; set; }

		/// <summary>
		/// The identifier of the branch.The field is included in the Branch foreign key.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The date when the cash discount is available for the invoice based on the credit terms.
		/// DAC Field Name: DiscDate 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Cash Discount Date 
		/// </summary>
		/// <remarks>
		/// This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="CashDiscountDate", EmitDefaultValue=false)]
		public DateTimeValue? CashDiscountDate { get; set; }

		/// <summary>
		/// The identifier of the tax zone to be used to process customer sales orders.The field is included in the TaxZone foreign key.
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Customer Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="CustomerTaxZone", EmitDefaultValue=false)]
		public StringValue? CustomerTaxZone { get; set; }

		/// <summary>
		/// The due date of the invoice according to the credit terms.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Due Date 
		/// </summary>
		/// <remarks>
		/// This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		/// <summary>
		/// The entity usage type of the customer location if sales to this location are tax-exempt.
		/// DAC Field Name: AvalaraCustomerUsageType 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Tax Exemption Type 
		/// SQL Type: char(1) 
		/// </summary>
		/// <remarks>
		/// This field is available only if theExternal Tax Calculation Integrationfeature is enabled on the Enable/Disable Features (CS100000) form.This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue? EntityUsageType { get; set; }

		/// <summary>
		/// The date of the invoice generated for the order.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Invoice Date 
		/// </summary>
		/// <remarks>
		/// Date can be entered manually if the Bill Separatelyfield is  for the order type.This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
		public DateTimeValue? InvoiceDate { get; set; }

		/// <summary>
		/// The reference number of the original invoice (which lists the goods that were ordered andlater returned by the customer).The field is included in the Invoice foreign key.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Invoice Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		/// <remarks>
		/// This field is available for orders of the CR, RC, RR, and RM types.
		/// </remarks>
		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// The identifier of the reference number of the original sales order.The field is included in the OriginalOrder foreign key.
		/// DAC Field Name: OrigOrderNbr 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Orig. Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		/// <remarks>
		/// The field is used only for returns.
		/// </remarks>
		[DataMember(Name="OriginalOrderNbr", EmitDefaultValue=false)]
		public StringValue? OriginalOrderNbr { get; set; }

		/// <summary>
		/// The identifier of the type of the original order.The field is included in the foreign keys OriginalOrderType andOriginalOrder.
		/// DAC Field Name: OrigOrderType 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Orig. Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		/// <remarks>
		/// The field is used only for returns.
		/// </remarks>
		[DataMember(Name="OriginalOrderType", EmitDefaultValue=false)]
		public StringValue? OriginalOrderType { get; set; }

		/// <summary>
		/// A Boolean value that specifies (if set to true) that the specified customer tax zone willnot be overridden if any location-related information is changed for the sales order.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Override Tax Zone 
		/// </summary>
		[DataMember(Name="OverrideTaxZone", EmitDefaultValue=false)]
		public BooleanValue? OverrideTaxZone { get; set; }

		/// <summary>
		/// The identifier of the employee in the workgroup who is responsible forthe sales order.The field is included in the Owner foreign key.
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// The period to post the transactions generated by the invoice.
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Post Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// The identifier of the credit terms used in relations with the customer.The field is included in the Terms foreign key.
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		/// <remarks>
		/// This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

	}
}