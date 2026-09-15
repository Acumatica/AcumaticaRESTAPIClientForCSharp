using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class InvoiceMemoPrintForm : IReport
	{
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
		
		[DataMember(Name="DocumentType", EmitDefaultValue=false)]
		public StringValue? DocumentType { get; set; }
		[DataMember(Name="ReferenceNumber", EmitDefaultValue=false)]
		public StringValue? ReferenceNumber { get; set; }
	}
}