using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class BillRetainageDocument : Entity
	{

		/// <summary>
		/// The amount to be paid for the document in the currency of the document. (See CuryID)
		/// <para>DAC Field Name: CuryOrigDocAmt</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The balance of the Accounts Payable document after tax (if inclusive) and the discount in the currency of the document. (See CuryID)
		/// <para>DAC Field Name: CuryDocBal</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// </summary>
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// Date of the document.
		/// <para>DAC Field Name: DocDate</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// </summary>
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// Description of the document.
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: APInvoice__PayTypeID</para>
		/// <para>DAC: PX.Objects.AP.APRetainageInvoice</para>
		/// </summary>
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// Financial Period of the document.
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// Reference number of the document.
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// The status of the document. The field is calculatedbased on the values of the status flag. It can't be changed directly.The following fields determine the status of the document: Hold,Released, Voided, Scheduled,Prebooked, Printed, Approved, Rejected.
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// Type of the document.
		/// <para>DAC Field Name: DocType</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC Field Name: APInvoice__InvoiceNbr</para>
		/// <para>DAC: PX.Objects.AP.APRetainageInvoice</para>
		/// </summary>
		public StringValue? VendorRef { get; set; }

	}
}