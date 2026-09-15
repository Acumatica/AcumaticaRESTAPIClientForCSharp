using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_26_200_001.Model
{
	[DataContract]
	public class UnlinkFileParameters
	{
		public UnlinkFileParameters() { }

		[DataMember(Name="Document", EmitDefaultValue=false)]
		public GuidValue? Document { get; set; }
		[DataMember(Name="DocumentNumber", EmitDefaultValue=false)]
		public StringValue? DocumentNumber { get; set; }
		[DataMember(Name="FileID", EmitDefaultValue=false)]
		public GuidValue? FileID { get; set; }
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }
		[DataMember(Name="RecordType", EmitDefaultValue=false)]
		public StringSingleSelectValue? RecordType { get; set; }
	}
}