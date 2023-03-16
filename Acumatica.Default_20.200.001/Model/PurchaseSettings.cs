using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class PurchaseSettings : Entity
	{

		[DataMember(Name="POSiteID", EmitDefaultValue=false)]
		public StringValue POSiteID { get; set; }

		[DataMember(Name="POSource", EmitDefaultValue=false)]
		public StringValue POSource { get; set; }

		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue VendorID { get; set; }

	}
}