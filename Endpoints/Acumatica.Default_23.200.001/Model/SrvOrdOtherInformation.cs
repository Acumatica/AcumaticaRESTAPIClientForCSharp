using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class SrvOrdOtherInformation : Entity
	{

		public StringValue? BatchNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LongDescr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public StringValue? DocumentType { get; set; }

		public StringValue? InvoiceNbr { get; set; }

		public StringValue? IssueReferenceNbr { get; set; }

		public StringValue? ReferenceNbr { get; set; }

	}
}