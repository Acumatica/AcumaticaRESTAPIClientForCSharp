using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class FinancialSettings : Entity
	{

		/// <summary>
		/// A Boolean value that indicates whether the document should be billed separately (that is, it requires aseparate invoice).
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Bill Separately</para>
		/// </summary>
		/// <remarks>
		/// This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="BillSeparately", EmitDefaultValue=false)]
		public BooleanValue? BillSeparately { get; set; }

		/// <summary>
		/// The identifier of the branch.The field is included in the Branch foreign key.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The date when the cash discount is available for the invoice based on the credit terms.
		/// <para>DAC Field Name: DiscDate</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Cash Discount Date</para>
		/// </summary>
		/// <remarks>
		/// This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="CashDiscountDate", EmitDefaultValue=false)]
		public DateTimeValue? CashDiscountDate { get; set; }

		/// <summary>
		/// The identifier of the tax zone to be used to process customer sales orders.The field is included in the TaxZone foreign key.
		/// <para>DAC Field Name: TaxZoneID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Customer Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="CustomerTaxZone", EmitDefaultValue=false)]
		public StringValue? CustomerTaxZone { get; set; }

		/// <summary>
		/// The due date of the invoice according to the credit terms.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Due Date</para>
		/// </summary>
		/// <remarks>
		/// This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		/// <summary>
		/// The entity usage type of the customer location if sales to this location are tax-exempt.
		/// <para>DAC Field Name: AvalaraCustomerUsageType</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Tax Exemption Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		/// <remarks>
		/// This field is available only if theExternal Tax Calculation Integrationfeature is enabled on the Enable/Disable Features (CS100000) form.This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue? EntityUsageType { get; set; }

		/// <summary>
		/// The date of the invoice generated for the order.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Invoice Date</para>
		/// </summary>
		/// <remarks>
		/// Date can be entered manually if the Bill Separatelyfield is  for the order type.This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
		public DateTimeValue? InvoiceDate { get; set; }

		/// <summary>
		/// The reference number of the original invoice (which lists the goods that were ordered andlater returned by the customer).The field is included in the Invoice foreign key.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Invoice Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		/// <remarks>
		/// This field is available for orders of the CR, RC, RR, and RM types.
		/// </remarks>
		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// The identifier of the reference number of the original sales order.The field is included in the OriginalOrder foreign key.
		/// <para>DAC Field Name: OrigOrderNbr</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Orig. Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		/// <remarks>
		/// The field is used only for returns.
		/// </remarks>
		[DataMember(Name="OriginalOrderNbr", EmitDefaultValue=false)]
		public StringValue? OriginalOrderNbr { get; set; }

		/// <summary>
		/// The identifier of the type of the original order.The field is included in the foreign keys OriginalOrderType andOriginalOrder.
		/// <para>DAC Field Name: OrigOrderType</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Orig. Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		/// <remarks>
		/// The field is used only for returns.
		/// </remarks>
		[DataMember(Name="OriginalOrderType", EmitDefaultValue=false)]
		public StringValue? OriginalOrderType { get; set; }

		/// <summary>
		/// A Boolean value that specifies (if set to true) that the specified customer tax zone willnot be overridden if any location-related information is changed for the sales order.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Override Tax Zone</para>
		/// </summary>
		[DataMember(Name="OverrideTaxZone", EmitDefaultValue=false)]
		public BooleanValue? OverrideTaxZone { get; set; }

		/// <summary>
		/// The identifier of the employee in the workgroup who is responsible forthe sales order.The field is included in the Owner foreign key.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// The period to post the transactions generated by the invoice.
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// The identifier of the credit terms used in relations with the customer.The field is included in the Terms foreign key.
		/// <para>DAC Field Name: TermsID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		/// <remarks>
		/// This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

	}
}