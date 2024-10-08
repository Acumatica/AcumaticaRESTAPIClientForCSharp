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
	public class ProFormaFinancialDetails : Entity
	{

		/// <summary>
		/// The type of the corresponding accounts receivable document created on release of the pro forma invoice.
		/// DAC Field Name: ARInvoiceDocType 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: AR Doc. Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="ARDocType", EmitDefaultValue=false)]
		public StringValue? ARDocType { get; set; }

		/// <summary>
		/// The reference number of the corresponding accounts receivable document created on release of the pro forma invoice.
		/// DAC Field Name: ARInvoiceRefNbr 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: AR Ref. Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ARRefNbr", EmitDefaultValue=false)]
		public StringValue? ARRefNbr { get; set; }

		/// <summary>
		/// The identifier of the Branch to which the pro forma invoice belongs.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The end date of the cash discount period, which the system calculates by using the credit terms.
		/// DAC Field Name: DiscDate 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Cash Discount Date 
		/// </summary>
		[DataMember(Name="CashDiscountDate", EmitDefaultValue=false)]
		public DateTimeValue? CashDiscountDate { get; set; }

		/// <summary>
		/// The identifier of the TaxZone associated with the document.
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Customer Tax Zone 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="CustomerTaxZone", EmitDefaultValue=false)]
		public StringValue? CustomerTaxZone { get; set; }

		/// <summary>
		/// The customer entity type for reporting purposes. The field is used if the system is integrated with an external tax calculation system and the External Tax            Calculation Integration feature is enabled.
		/// DAC Field Name: AvalaraCustomerUsageType 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Tax Exemption Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="CustomerUsageType", EmitDefaultValue=false)]
		public StringValue? CustomerUsageType { get; set; }

		/// <summary>
		/// The date when the payment for the document is due, in accordance with the credit terms.
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Due Date 
		/// </summary>
		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		/// <summary>
		/// The identifier of the credit terms object associated with the document.
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.PM.PMProforma 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

	}
}