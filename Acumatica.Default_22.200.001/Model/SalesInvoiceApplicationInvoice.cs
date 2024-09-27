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
	public class SalesInvoiceApplicationInvoice : Entity
	{

		[DataMember(Name="AdjustedDocReferenceNbr", EmitDefaultValue=false)]
		public StringValue? AdjustedDocReferenceNbr { get; set; }

		/// <summary>
		/// DAC Field Name: AdjgRefNbr 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AdjustingDocReferenceNbr", EmitDefaultValue=false)]
		public StringValue? AdjustingDocReferenceNbr { get; set; }

		/// <summary>
		/// DAC Field Name: AdjNbr 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// Display Name: Adjustment Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="AdjustmentNbr", EmitDefaultValue=false)]
		public IntValue? AdjustmentNbr { get; set; }

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
		/// DAC Field Name: CuryAdjgDiscAmt 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// Display Name: Cash Discount Taken 
		/// </summary>
		[DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountTaken { get; set; }

		/// <summary>
		/// DAC Field Name: ARPayment__CuryID 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// The identifier of the Customer record associated with the document.
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// DAC Field Name: ARPayment__DocDesc 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: AdjgDocType 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// Display Name: Doc. Type 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		[DataMember(Name="DocumentType", EmitDefaultValue=false)]
		public StringValue? DocumentType { get; set; }

		/// <summary>
		/// DAC Field Name: ARPayment__DocDate 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// </summary>
		[DataMember(Name="PaymentDate", EmitDefaultValue=false)]
		public DateTimeValue? PaymentDate { get; set; }

		/// <summary>
		/// DAC Field Name: ARPayment__FinPeriodID 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// </summary>
		[DataMember(Name="PaymentPeriod", EmitDefaultValue=false)]
		public StringValue? PaymentPeriod { get; set; }

		/// <summary>
		/// DAC Field Name: ARPayment__ExtRefNbr 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// </summary>
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// DAC Field Name: ARPayment__Status 
		/// DAC: PX.Objects.AR.ARAdjust2 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}