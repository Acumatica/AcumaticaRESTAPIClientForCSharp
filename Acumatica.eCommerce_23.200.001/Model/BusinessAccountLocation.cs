using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class BusinessAccountLocation : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

	}
}