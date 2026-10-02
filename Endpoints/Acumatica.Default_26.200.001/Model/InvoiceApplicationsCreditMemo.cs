using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class InvoiceApplicationsCreditMemo : Entity
	{

		#region Fields
		/// <summary>
		/// The open balance of the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryDocBal</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__InvoiceNbr</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		public StringValue? CustomerOrder { get; set; }

		public DecimalValue? AmountPaid { get; set; }

		public StringValue? Customer { get; set; }

		public StringValue? Description { get; set; }

		public StringSingleSelectValue? DocType { get; set; }

		public StringValue? PostPeriod { get; set; }

		public StringValue? ReferenceNbr { get; set; }

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