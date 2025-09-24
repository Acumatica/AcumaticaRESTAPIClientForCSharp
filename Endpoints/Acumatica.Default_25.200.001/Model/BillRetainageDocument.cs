using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class BillRetainageDocument : Entity
	{

		/// <summary>
		/// The amount to be paid for the document in the currency of the document. (See CuryID)
		/// DAC Field Name: CuryOrigDocAmt 
		/// DAC: PX.Objects.AP.APInvoice 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The balance of the Accounts Payable document after tax (if inclusive) and the discount in the currency of the document. (See CuryID)
		/// DAC Field Name: CuryDocBal 
		/// DAC: PX.Objects.AP.APInvoice 
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// Date of the document.
		/// DAC Field Name: DocDate 
		/// DAC: PX.Objects.AP.APInvoice 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// Description of the document.
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.AP.APInvoice 
		/// SQL Type: nvarchar(512) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: APInvoice__PayTypeID 
		/// DAC: PX.Objects.AP.APRetainageInvoice 
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// Financial Period of the document.
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.AP.APInvoice 
		/// Display Name: Post Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// Reference number of the document.
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AP.APInvoice 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// The status of the document. The field is calculatedbased on the values of the status flag. It can't be changed directly.The following fields determine the status of the document: Hold,Released, Voided, Scheduled,Prebooked, Printed, Approved, Rejected.
		/// DAC: PX.Objects.AP.APInvoice 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// Type of the document.
		/// DAC Field Name: DocType 
		/// DAC: PX.Objects.AP.APInvoice 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// DAC Field Name: APInvoice__InvoiceNbr 
		/// DAC: PX.Objects.AP.APRetainageInvoice 
		/// </summary>
		[DataMember(Name="VendorRef", EmitDefaultValue=false)]
		public StringValue? VendorRef { get; set; }

	}
}