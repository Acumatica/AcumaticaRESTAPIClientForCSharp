using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Report_1.Model
{
	public class ARInvoice : IReport
	{
		public virtual string GetEndpointPath()
		{
			return "entity/Report/1";
		}
		
		public StringValue? DocumentType { get; set; }
		public StringValue? ReferenceNumber { get; set; }
		public StringValue? LineTypeDS { get; set; }
		public StringValue? PrepaymentInvoiceFullName { get; set; }
	}
}