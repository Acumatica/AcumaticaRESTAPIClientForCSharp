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
	public class InvoiceApplicationsDefault : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryAdjdAmt 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// Display Name: Amount Paid 
		/// </summary>
		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// The open balance of the document.Given in the currency of the document.
		/// DAC Field Name: CuryDocBal 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// The cash discount amount displayed for the document.Given in the  currency of the adjusted document.
		/// DAC Field Name: CuryAdjdPPDAmt 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// Display Name: Cash Discount Taken 
		/// </summary>
		[DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountTaken { get; set; }

		/// <summary>
		/// DAC Field Name: AdjgDocType 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// Display Name: Doc. Type 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// DAC Field Name: ARPayment__DocDate 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// </summary>
		[DataMember(Name="PaymentDate", EmitDefaultValue=false)]
		public DateTimeValue? PaymentDate { get; set; }

		/// <summary>
		/// DAC Field Name: AdjgRefNbr 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ARPayment__Status 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}