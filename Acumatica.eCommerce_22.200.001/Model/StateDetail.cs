using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class StateDetail : Entity
	{

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		[DataMember(Name="StateID", EmitDefaultValue=false)]
		public StringValue? StateID { get; set; }

		[DataMember(Name="StateName", EmitDefaultValue=false)]
		public StringValue? StateName { get; set; }

		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="SalesTerritoryID", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryID { get; set; }

	}
}