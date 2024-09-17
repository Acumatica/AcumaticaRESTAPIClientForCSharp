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
	public class SubcontractVendorContactInfo : Entity
	{

		[DataMember(Name="AccountName", EmitDefaultValue=false)]
		public StringValue? AccountName { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="JobTitle", EmitDefaultValue=false)]
		public StringValue? JobTitle { get; set; }

		[DataMember(Name="VendorContactOverride", EmitDefaultValue=false)]
		public BooleanValue? VendorContactOverride { get; set; }

		[DataMember(Name="Phone", EmitDefaultValue=false)]
		public StringValue? Phone { get; set; }

	}
}