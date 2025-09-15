using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Report_1.Model
{
	[DataContract]
	public class ARInvoice : IReport
	{
		public virtual string GetEndpointPath()
		{
			return "entity/Report/1";
		}
		
		[DataMember(Name="DocumentType", EmitDefaultValue=false)]
		public StringValue? DocumentType { get; set; }
		[DataMember(Name="ReferenceNumber", EmitDefaultValue=false)]
		public StringValue? ReferenceNumber { get; set; }
		[DataMember(Name="LineTypeDS", EmitDefaultValue=false)]
		public StringValue? LineTypeDS { get; set; }
		[DataMember(Name="PrepaymentInvoiceFullName", EmitDefaultValue=false)]
		public StringValue? PrepaymentInvoiceFullName { get; set; }
	}
}