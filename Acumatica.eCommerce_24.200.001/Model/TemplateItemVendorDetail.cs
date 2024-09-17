using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class TemplateItemVendorDetail : Entity
	{

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

	}
}