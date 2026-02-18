using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class SalesInvoiceApplicationCreditMemo : Entity
	{

		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// The open balance of the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryDocBal</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		public DecimalValue? Balance { get; set; }

		public StringValue? Currency { get; set; }

		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__InvoiceNbr</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		public StringValue? CustomerOrder { get; set; }

		public DateTimeValue? Date { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? DocType { get; set; }

		public StringValue? PostPeriod { get; set; }

		public StringValue? ReferenceNbr { get; set; }

		public StringValue? Status { get; set; }

	}
}