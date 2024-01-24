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
	public class CountryDetail : Entity
	{

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		[DataMember(Name="CountryID", EmitDefaultValue=false)]
		public StringValue? CountryID { get; set; }

		[DataMember(Name="CountryName", EmitDefaultValue=false)]
		public StringValue? CountryName { get; set; }

		[DataMember(Name="SalesTerritoryID", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryID { get; set; }

	}
}