using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class BillApplicationDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryAdjdAmt</para>
		/// <para>DAC: PX.Objects.AP.APInvoiceEntry+APAdjust</para>
		/// </summary>
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// The balance of the Accounts Payable document after tax (if inclusive) and the discount in the currency of the document. (See CuryID)
		/// <para>DAC Field Name: CuryDocBal</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// </summary>
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DisplayDocType</para>
		/// <para>DAC: PX.Objects.AP.APInvoiceEntry+APAdjust</para>
		/// </summary>
		public StringValue? DocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DisplayRefNbr</para>
		/// <para>DAC: PX.Objects.AP.APInvoiceEntry+APAdjust</para>
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DisplayStatus</para>
		/// <para>DAC: PX.Objects.AP.APInvoiceEntry+APAdjust</para>
		/// </summary>
		public StringValue? Status { get; set; }

	}
}