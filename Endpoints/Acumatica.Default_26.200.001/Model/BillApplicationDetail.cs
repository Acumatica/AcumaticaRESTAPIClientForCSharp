using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class BillApplicationDetail : Entity
	{

		#region Fields
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
		/// <para>DAC Field Name: CuryAdjdAmt</para>
		/// <para>DAC: PX.Objects.AP.APInvoiceEntry+APAdjust</para>
		/// </summary>
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DisplayStatus</para>
		/// <para>DAC: PX.Objects.AP.APInvoiceEntry+APAdjust</para>
		/// </summary>
		public StringSingleSelectValue? Status { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}